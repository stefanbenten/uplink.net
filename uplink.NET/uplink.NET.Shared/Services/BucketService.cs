﻿using System;
using System.Collections.Generic;
using System.Text;
using uplink.NET.Exceptions;
using uplink.NET.Interfaces;
using uplink.NET.Models;

namespace uplink.NET.Services
{
    public class BucketService : IBucketService
    {
        public void CloseBucket(BucketRef bucketRef)
        {
            throw new NotImplementedException();
        }

        public BucketInfo CreateBucket(Project project, string bucketName, BucketConfig bucketConfig)
        {
            Models.BucketConfig _bucketConfig = bucketConfig as Models.BucketConfig;
            Models.Project _project = project as Models.Project;
            string error;
            var res = SWIG.storj_uplink.create_bucket(_project._projectRef, bucketName, _bucketConfig.ToSWIG(), out error);

            if (!string.IsNullOrEmpty(error))
                throw new BucketCreationException(error);

            return BucketInfo.FromSWIG(res);
        }

        public void DeleteBucket(Project project, string bucketName)
        {
            string error;

            SWIG.storj_uplink.delete_bucket(project._projectRef, bucketName, out error);
        }

        public BucketInfo GetBucketInfo(Project project, string bucketName)
        {
            throw new NotImplementedException();
        }

        public BucketList ListBuckets(Project project, BucketListOptions bucketListOptions)
        {
            string error;
            Models.BucketListOptions _bucketListOptions = bucketListOptions as Models.BucketListOptions;
            Models.Project _project = project as Models.Project;

            var res = SWIG.storj_uplink.list_buckets(_project._projectRef, _bucketListOptions.ToSWIG(), out error);

            return BucketList.FromSWIG(res);
        }

        public BucketRef OpenBucket(Project project, string bucketName, EncryptionAccess encryptionAccess)
        {
            throw new NotImplementedException();
        }
    }
}
