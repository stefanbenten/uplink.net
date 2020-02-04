﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using uplink.NET.Interfaces;
using uplink.NET.Models;
using uplink.NET.Services;

namespace uplink.NET.Test
{
    [TestClass]
    public class ScopeTest
    {
        Scope _scope;
        IBucketService _bucketService;
        IObjectService _objectService;
        BucketConfig _bucketConfig;

        [TestInitialize]
        public void Init()
        {
            Scope.SetTempDirectory(System.IO.Path.GetTempPath());
            _scope = new Scope(TestConstants.VALID_API_KEY, TestConstants.SATELLITE_URL, TestConstants.ENCRYPTION_SECRET);
            _bucketService = new BucketService(_scope);
            _objectService = new ObjectService();
            _bucketConfig = new BucketConfig();
        }

        [TestMethod]
        public void CreateValidScope_Crestes_ValidScope()
        {
            using (Scope scope = new Scope(TestConstants.SATELLITE_URL, _scope.GetAPIKey(), _scope.GetEncryptionAccess()))
            {
                Assert.AreEqual(_scope.GetAPIKey().GetAPIKey(), scope.GetAPIKey().GetAPIKey());
                Assert.AreEqual(TestConstants.SATELLITE_URL, scope.GetSatelliteAddress());
            }
        }

        [TestMethod]
        public void RestrictScope_Creates_ValidScope()
        {
            using (Scope scope = new Scope(TestConstants.SATELLITE_URL, _scope.GetAPIKey(), _scope.GetEncryptionAccess()))
            {
                Caveat caveat = new Caveat() { DisallowWrites = true };
                List<EncryptionRestriction> restrictions = new List<EncryptionRestriction>();
                restrictions.Add(new EncryptionRestriction() { Bucket = "bucket1", PathPrefix = "/" });
                var restricted = scope.Restrict(caveat, restrictions);
                Assert.IsNotNull(restricted);

                Assert.AreEqual(TestConstants.SATELLITE_URL, restricted.GetSatelliteAddress());
            }
        }

        [TestMethod]
        public async Task RestrictScope_Creates_UsableRestrictedScopeForUpload()
        {
            string serializedScope;
            string bucketname = "restrictscope-creates-usablerestrictedscopeforupload";
            byte[] bytesToUpload = ObjectServiceTest.GetRandomBytes(2048);

            using (Scope scope = new Scope(TestConstants.SATELLITE_URL, _scope.GetAPIKey(), _scope.GetEncryptionAccess()))
            {
                await _bucketService.CreateBucketAsync(bucketname, _bucketConfig);

                Caveat caveat = new Caveat();
                List<EncryptionRestriction> restrictions = new List<EncryptionRestriction>();
                restrictions.Add(new EncryptionRestriction() { Bucket = bucketname, PathPrefix = "test" });
                var restricted = scope.Restrict(caveat, restrictions);
                serializedScope = restricted.Serialize();
            }

            Scope restrictedEnv;
            try
            {
                restrictedEnv = new Scope(serializedScope);
            }
            catch
            {
                Assert.Fail("Failed to create restricted scope from serialized scope");
                return;
            }

            var restrictedObjectService = new ObjectService();
            var restrictedBucketService = new BucketService(restrictedEnv);
            var restrictedBucket = await restrictedBucketService.OpenBucketAsync(bucketname);
            var uploadOperationRestricted = await restrictedObjectService.UploadObjectAsync(restrictedBucket, "test/subfolder/test-file-upload", new UploadOptions(), bytesToUpload, false);
            await uploadOperationRestricted.StartUploadAsync();

            Assert.IsTrue(uploadOperationRestricted.Completed);
            Assert.AreEqual((ulong)bytesToUpload.Length, uploadOperationRestricted.BytesSent);
        }

        [TestMethod]
        public async Task RestrictScope_Creates_UsableRestrictedScopeForUploadWithDisallowDeletes()
        {
            string serializedScope;
            string bucketname = "restrictscope-creates-usablerestrictedscopeforupload";
            byte[] bytesToUpload = ObjectServiceTest.GetRandomBytes(2048);

            using (Scope scope = new Scope(TestConstants.SATELLITE_URL, _scope.GetAPIKey(), _scope.GetEncryptionAccess()))
            {
                await _bucketService.CreateBucketAsync(bucketname, _bucketConfig);

                Caveat caveat = new Caveat();
                caveat.DisallowReads = true; //should not change anything as we are uploading here
                List<EncryptionRestriction> restrictions = new List<EncryptionRestriction>();
                restrictions.Add(new EncryptionRestriction() { Bucket = bucketname, PathPrefix = "test" });
                var restricted = scope.Restrict(caveat, restrictions);
                serializedScope = restricted.Serialize();
            }

            Scope restrictedEnv;
            try
            {
                restrictedEnv = new Scope(serializedScope);
            }
            catch
            {
                Assert.Fail("Failed to create restricted scope from serialized scope");
                return;
            }

            var restrictedObjectService = new ObjectService();
            var restrictedBucketService = new BucketService(restrictedEnv);
            var restrictedBucket = await restrictedBucketService.OpenBucketAsync(bucketname);
            var uploadOperationRestricted = await restrictedObjectService.UploadObjectAsync(restrictedBucket, "test/subfolder/test-file-upload", new UploadOptions(), bytesToUpload, false);
            await uploadOperationRestricted.StartUploadAsync();

            Assert.IsTrue(uploadOperationRestricted.Completed);
            Assert.AreEqual((ulong)bytesToUpload.Length, uploadOperationRestricted.BytesSent);
        }

        [TestMethod]
        public async Task RestrictScope_Creates_UsableRestrictedScopeForUploadDeep()
        {
            string serializedScope;
            string bucketname = "restrictscope-creates-usablerestrictedscopeforuploaddeep";
            byte[] bytesToUpload = ObjectServiceTest.GetRandomBytes(2048);

            using (Scope scope = new Scope(TestConstants.SATELLITE_URL, _scope.GetAPIKey(), _scope.GetEncryptionAccess()))
            {
                await _bucketService.CreateBucketAsync(bucketname, _bucketConfig);

                Caveat caveat = new Caveat();
                caveat.DisallowDeletes = true; //Should not change anything as we are uploading here
                List<EncryptionRestriction> restrictions = new List<EncryptionRestriction>();
                restrictions.Add(new EncryptionRestriction() { Bucket = bucketname, PathPrefix = "test/subfolder" });
                var restricted = scope.Restrict(caveat, restrictions);
                serializedScope = restricted.Serialize();
            }

            Scope restrictedEnv;
            try
            {
                restrictedEnv = new Scope(serializedScope);
            }
            catch
            {
                Assert.Fail("Failed to create restricted scope from serialized scope");
                return;
            }

            var restrictedObjectService = new ObjectService();
            var restrictedBucketService = new BucketService(restrictedEnv);
            var restrictedBucket = await restrictedBucketService.OpenBucketAsync(bucketname);
            var uploadOperationRestricted = await restrictedObjectService.UploadObjectAsync(restrictedBucket, "test/subfolder/test-file-upload", new UploadOptions(), bytesToUpload, false);
            await uploadOperationRestricted.StartUploadAsync();

            Assert.IsTrue(uploadOperationRestricted.Completed);
            Assert.AreEqual((ulong)bytesToUpload.Length, uploadOperationRestricted.BytesSent);
        }

        [TestMethod]
        public async Task RestrictScope_Creates_UsableRestrictedScopeForDownload()
        {
            string serializedScope;
            string bucketname = "restrictscope-creates-usablerestrictedscopefordownload";
            byte[] bytesToUpload = ObjectServiceTest.GetRandomBytes(2048);

            using (Scope scope = new Scope(TestConstants.SATELLITE_URL, _scope.GetAPIKey(), _scope.GetEncryptionAccess()))
            {
                await _bucketService.CreateBucketAsync(bucketname, _bucketConfig);
                var bucket = await _bucketService.OpenBucketAsync(bucketname);

                var uploadOperation = await _objectService.UploadObjectAsync(bucket, "test/test-file", new UploadOptions(), bytesToUpload, false);
                await uploadOperation.StartUploadAsync();

                Caveat caveat = new Caveat();
                caveat.DisallowWrites = true; //Should not change anything as we are downloading here
                List<EncryptionRestriction> restrictions = new List<EncryptionRestriction>();
                restrictions.Add(new EncryptionRestriction() { Bucket = bucketname, PathPrefix = "test" });
                var restricted = scope.Restrict(caveat, restrictions);
                serializedScope = restricted.Serialize();
            }

            Scope restrictedEnv;
            try
            {
                restrictedEnv = new Scope(serializedScope);
            }
            catch
            {
                Assert.Fail("Failed to create restricted scope from serialized scope");
                return;
            }

            var restrictedObjectService = new ObjectService();
            var restrictedBucketService = new BucketService(restrictedEnv);
            var restrictedBucket = await restrictedBucketService.OpenBucketAsync(bucketname);
            var downloadOperation = await restrictedObjectService.DownloadObjectAsync(restrictedBucket, "test/test-file", false);
            await downloadOperation.StartDownloadAsync();

            Assert.IsTrue(downloadOperation.Completed);
            Assert.AreEqual((ulong)bytesToUpload.Length, downloadOperation.BytesReceived);

            for (int i = 0; i < bytesToUpload.Length; i++)
            {
                Assert.AreEqual(bytesToUpload[i], downloadOperation.DownloadedBytes[i], "DownloadedBytes are not equal at index " + i);
            }
        }

        [TestCleanup]
        public async Task CleanupAsync()
        {
            await DeleteBucketAsync("restrictscope-creates-usablerestrictedscopeforupload");
            await DeleteBucketAsync("restrictscope-creates-usablerestrictedscopeforuploaddeep");
            await DeleteBucketAsync("restrictscope-creates-usablerestrictedscopefordownload");
        }

        private async Task DeleteBucketAsync(string bucketName)
        {
            try
            {
                await _bucketService.DeleteBucketAsync(bucketName);
            }
            catch
            { }
        }
    }
}
