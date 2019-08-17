//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace uplink.SWIG {

public class storj_uplink {
  public static APIKeyRef parse_api_key(string p0, out string p1) {
global::System.IntPtr tmpp1=global::System.IntPtr.Zero;
    try {
      APIKeyRef ret = new APIKeyRef(storj_uplinkPINVOKE.parse_api_key(p0, ref tmpp1), true);
      return ret;
    } finally {
p1=global::System.Runtime.InteropServices.Marshal.PtrToStringAnsi(tmpp1);
			  if(tmpp1 != System.IntPtr.Zero) storj_uplinkPINVOKE.free_string(tmpp1);
    }
  }

  public static string serialize_api_key(APIKeyRef p0, out string p1) {
global::System.IntPtr tmpp1=global::System.IntPtr.Zero;
    try {
      string ret = storj_uplinkPINVOKE.serialize_api_key(APIKeyRef.getCPtr(p0), ref tmpp1);
      if (storj_uplinkPINVOKE.SWIGPendingException.Pending) throw storj_uplinkPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } finally {
p1=global::System.Runtime.InteropServices.Marshal.PtrToStringAnsi(tmpp1);
			  if(tmpp1 != System.IntPtr.Zero) storj_uplinkPINVOKE.free_string(tmpp1);
    }
  }

  public static void free_api_key(APIKeyRef p0) {
    storj_uplinkPINVOKE.free_api_key(APIKeyRef.getCPtr(p0));
    if (storj_uplinkPINVOKE.SWIGPendingException.Pending) throw storj_uplinkPINVOKE.SWIGPendingException.Retrieve();
  }

  public static BucketInfo create_bucket(ProjectRef p0, string p1, BucketConfig p2, out string p3) {
global::System.IntPtr tmpp3=global::System.IntPtr.Zero;
    try {
      BucketInfo ret = new BucketInfo(storj_uplinkPINVOKE.create_bucket(ProjectRef.getCPtr(p0), p1, BucketConfig.getCPtr(p2), ref tmpp3), true);
      if (storj_uplinkPINVOKE.SWIGPendingException.Pending) throw storj_uplinkPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } finally {
p3=global::System.Runtime.InteropServices.Marshal.PtrToStringAnsi(tmpp3);
			  if(tmpp3 != System.IntPtr.Zero) storj_uplinkPINVOKE.free_string(tmpp3);
    }
  }

  public static BucketInfo get_bucket_info(ProjectRef p0, string p1, out string p2) {
global::System.IntPtr tmpp2=global::System.IntPtr.Zero;
    try {
      BucketInfo ret = new BucketInfo(storj_uplinkPINVOKE.get_bucket_info(ProjectRef.getCPtr(p0), p1, ref tmpp2), true);
      if (storj_uplinkPINVOKE.SWIGPendingException.Pending) throw storj_uplinkPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } finally {
p2=global::System.Runtime.InteropServices.Marshal.PtrToStringAnsi(tmpp2);
			  if(tmpp2 != System.IntPtr.Zero) storj_uplinkPINVOKE.free_string(tmpp2);
    }
  }

  public static BucketRef open_bucket(ProjectRef p0, string p1, string p2, out string p3) {
global::System.IntPtr tmpp3=global::System.IntPtr.Zero;
    try {
      BucketRef ret = new BucketRef(storj_uplinkPINVOKE.open_bucket(ProjectRef.getCPtr(p0), p1, p2, ref tmpp3), true);
      if (storj_uplinkPINVOKE.SWIGPendingException.Pending) throw storj_uplinkPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } finally {
p3=global::System.Runtime.InteropServices.Marshal.PtrToStringAnsi(tmpp3);
			  if(tmpp3 != System.IntPtr.Zero) storj_uplinkPINVOKE.free_string(tmpp3);
    }
  }

  public static BucketList list_buckets(ProjectRef p0, BucketListOptions p1, out string p2) {
global::System.IntPtr tmpp2=global::System.IntPtr.Zero;
    try {
      BucketList ret = new BucketList(storj_uplinkPINVOKE.list_buckets(ProjectRef.getCPtr(p0), BucketListOptions.getCPtr(p1), ref tmpp2), true);
      if (storj_uplinkPINVOKE.SWIGPendingException.Pending) throw storj_uplinkPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } finally {
p2=global::System.Runtime.InteropServices.Marshal.PtrToStringAnsi(tmpp2);
			  if(tmpp2 != System.IntPtr.Zero) storj_uplinkPINVOKE.free_string(tmpp2);
    }
  }

  public static void delete_bucket(ProjectRef p0, string p1, out string p2) {
global::System.IntPtr tmpp2=global::System.IntPtr.Zero;
    try {
      storj_uplinkPINVOKE.delete_bucket(ProjectRef.getCPtr(p0), p1, ref tmpp2);
      if (storj_uplinkPINVOKE.SWIGPendingException.Pending) throw storj_uplinkPINVOKE.SWIGPendingException.Retrieve();
    } finally {
p2=global::System.Runtime.InteropServices.Marshal.PtrToStringAnsi(tmpp2);
			  if(tmpp2 != System.IntPtr.Zero) storj_uplinkPINVOKE.free_string(tmpp2);
    }
  }

  public static void close_bucket(BucketRef p0, out string p1) {
global::System.IntPtr tmpp1=global::System.IntPtr.Zero;
    try {
      storj_uplinkPINVOKE.close_bucket(BucketRef.getCPtr(p0), ref tmpp1);
      if (storj_uplinkPINVOKE.SWIGPendingException.Pending) throw storj_uplinkPINVOKE.SWIGPendingException.Retrieve();
    } finally {
p1=global::System.Runtime.InteropServices.Marshal.PtrToStringAnsi(tmpp1);
			  if(tmpp1 != System.IntPtr.Zero) storj_uplinkPINVOKE.free_string(tmpp1);
    }
  }

  public static void free_bucket_info(BucketInfo p0) {
    storj_uplinkPINVOKE.free_bucket_info(BucketInfo.getCPtr(p0));
  }

  public static void free_bucket_list(BucketList p0) {
    storj_uplinkPINVOKE.free_bucket_list(BucketList.getCPtr(p0));
  }

  public static EncryptionAccessRef new_encryption_access(out string p0) {
global::System.IntPtr tmpp0=global::System.IntPtr.Zero;
    try {
      EncryptionAccessRef ret = new EncryptionAccessRef(storj_uplinkPINVOKE.new_encryption_access(ref tmpp0), true);
      return ret;
    } finally {
p0=global::System.Runtime.InteropServices.Marshal.PtrToStringAnsi(tmpp0);
			  if(tmpp0 != System.IntPtr.Zero) storj_uplinkPINVOKE.free_string(tmpp0);
    }
  }

  public static EncryptionAccessRef new_encryption_access_with_default_key(SWIGTYPE_p_uint8_t p0) {
    EncryptionAccessRef ret = new EncryptionAccessRef(storj_uplinkPINVOKE.new_encryption_access_with_default_key(SWIGTYPE_p_uint8_t.getCPtr(p0)), true);
    return ret;
  }

  public static void set_default_key(EncryptionAccessRef p0, SWIGTYPE_p_uint8_t p1, out string p2) {
global::System.IntPtr tmpp2=global::System.IntPtr.Zero;
    try {
      storj_uplinkPINVOKE.set_default_key(EncryptionAccessRef.getCPtr(p0), SWIGTYPE_p_uint8_t.getCPtr(p1), ref tmpp2);
      if (storj_uplinkPINVOKE.SWIGPendingException.Pending) throw storj_uplinkPINVOKE.SWIGPendingException.Retrieve();
    } finally {
p2=global::System.Runtime.InteropServices.Marshal.PtrToStringAnsi(tmpp2);
			  if(tmpp2 != System.IntPtr.Zero) storj_uplinkPINVOKE.free_string(tmpp2);
    }
  }

  public static string serialize_encryption_access(EncryptionAccessRef p0, out string p1) {
global::System.IntPtr tmpp1=global::System.IntPtr.Zero;
    try {
      string ret = storj_uplinkPINVOKE.serialize_encryption_access(EncryptionAccessRef.getCPtr(p0), ref tmpp1);
      if (storj_uplinkPINVOKE.SWIGPendingException.Pending) throw storj_uplinkPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } finally {
p1=global::System.Runtime.InteropServices.Marshal.PtrToStringAnsi(tmpp1);
			  if(tmpp1 != System.IntPtr.Zero) storj_uplinkPINVOKE.free_string(tmpp1);
    }
  }

  public static EncryptionAccessRef parse_encryption_access(string p0, out string p1) {
global::System.IntPtr tmpp1=global::System.IntPtr.Zero;
    try {
      EncryptionAccessRef ret = new EncryptionAccessRef(storj_uplinkPINVOKE.parse_encryption_access(p0, ref tmpp1), true);
      return ret;
    } finally {
p1=global::System.Runtime.InteropServices.Marshal.PtrToStringAnsi(tmpp1);
			  if(tmpp1 != System.IntPtr.Zero) storj_uplinkPINVOKE.free_string(tmpp1);
    }
  }

  public static void free_encryption_access(EncryptionAccessRef p0) {
    storj_uplinkPINVOKE.free_encryption_access(EncryptionAccessRef.getCPtr(p0));
    if (storj_uplinkPINVOKE.SWIGPendingException.Pending) throw storj_uplinkPINVOKE.SWIGPendingException.Retrieve();
  }

  public static ObjectRef open_object(BucketRef p0, string p1, out string p2) {
global::System.IntPtr tmpp2=global::System.IntPtr.Zero;
    try {
      ObjectRef ret = new ObjectRef(storj_uplinkPINVOKE.open_object(BucketRef.getCPtr(p0), p1, ref tmpp2), true);
      if (storj_uplinkPINVOKE.SWIGPendingException.Pending) throw storj_uplinkPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } finally {
p2=global::System.Runtime.InteropServices.Marshal.PtrToStringAnsi(tmpp2);
			  if(tmpp2 != System.IntPtr.Zero) storj_uplinkPINVOKE.free_string(tmpp2);
    }
  }

  public static void close_object(ObjectRef p0, out string p1) {
global::System.IntPtr tmpp1=global::System.IntPtr.Zero;
    try {
      storj_uplinkPINVOKE.close_object(ObjectRef.getCPtr(p0), ref tmpp1);
      if (storj_uplinkPINVOKE.SWIGPendingException.Pending) throw storj_uplinkPINVOKE.SWIGPendingException.Retrieve();
    } finally {
p1=global::System.Runtime.InteropServices.Marshal.PtrToStringAnsi(tmpp1);
			  if(tmpp1 != System.IntPtr.Zero) storj_uplinkPINVOKE.free_string(tmpp1);
    }
  }

  public static ObjectMeta get_object_meta(ObjectRef p0, out string p1) {
global::System.IntPtr tmpp1=global::System.IntPtr.Zero;
    try {
      ObjectMeta ret = new ObjectMeta(storj_uplinkPINVOKE.get_object_meta(ObjectRef.getCPtr(p0), ref tmpp1), true);
      if (storj_uplinkPINVOKE.SWIGPendingException.Pending) throw storj_uplinkPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } finally {
p1=global::System.Runtime.InteropServices.Marshal.PtrToStringAnsi(tmpp1);
			  if(tmpp1 != System.IntPtr.Zero) storj_uplinkPINVOKE.free_string(tmpp1);
    }
  }

  public static UploaderRef upload(BucketRef p0, string p1, UploadOptions p2, out string p3) {
global::System.IntPtr tmpp3=global::System.IntPtr.Zero;
    try {
      UploaderRef ret = new UploaderRef(storj_uplinkPINVOKE.upload(BucketRef.getCPtr(p0), p1, UploadOptions.getCPtr(p2), ref tmpp3), true);
      if (storj_uplinkPINVOKE.SWIGPendingException.Pending) throw storj_uplinkPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } finally {
p3=global::System.Runtime.InteropServices.Marshal.PtrToStringAnsi(tmpp3);
			  if(tmpp3 != System.IntPtr.Zero) storj_uplinkPINVOKE.free_string(tmpp3);
    }
  }

  public static uint upload_write(UploaderRef p0, SWIGTYPE_p_uint8_t p1, uint p2, out string p3) {
global::System.IntPtr tmpp3=global::System.IntPtr.Zero;
    try {
      uint ret = storj_uplinkPINVOKE.upload_write(UploaderRef.getCPtr(p0), SWIGTYPE_p_uint8_t.getCPtr(p1), p2, ref tmpp3);
      if (storj_uplinkPINVOKE.SWIGPendingException.Pending) throw storj_uplinkPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } finally {
p3=global::System.Runtime.InteropServices.Marshal.PtrToStringAnsi(tmpp3);
			  if(tmpp3 != System.IntPtr.Zero) storj_uplinkPINVOKE.free_string(tmpp3);
    }
  }

  public static void upload_commit(UploaderRef p0, out string p1) {
global::System.IntPtr tmpp1=global::System.IntPtr.Zero;
    try {
      storj_uplinkPINVOKE.upload_commit(UploaderRef.getCPtr(p0), ref tmpp1);
      if (storj_uplinkPINVOKE.SWIGPendingException.Pending) throw storj_uplinkPINVOKE.SWIGPendingException.Retrieve();
    } finally {
p1=global::System.Runtime.InteropServices.Marshal.PtrToStringAnsi(tmpp1);
			  if(tmpp1 != System.IntPtr.Zero) storj_uplinkPINVOKE.free_string(tmpp1);
    }
  }

  public static void upload_cancel(UploaderRef p0, out string p1) {
global::System.IntPtr tmpp1=global::System.IntPtr.Zero;
    try {
      storj_uplinkPINVOKE.upload_cancel(UploaderRef.getCPtr(p0), ref tmpp1);
      if (storj_uplinkPINVOKE.SWIGPendingException.Pending) throw storj_uplinkPINVOKE.SWIGPendingException.Retrieve();
    } finally {
p1=global::System.Runtime.InteropServices.Marshal.PtrToStringAnsi(tmpp1);
			  if(tmpp1 != System.IntPtr.Zero) storj_uplinkPINVOKE.free_string(tmpp1);
    }
  }

  public static ObjectList list_objects(BucketRef p0, ListOptions p1, out string p2) {
global::System.IntPtr tmpp2=global::System.IntPtr.Zero;
    try {
      ObjectList ret = new ObjectList(storj_uplinkPINVOKE.list_objects(BucketRef.getCPtr(p0), ListOptions.getCPtr(p1), ref tmpp2), true);
      if (storj_uplinkPINVOKE.SWIGPendingException.Pending) throw storj_uplinkPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } finally {
p2=global::System.Runtime.InteropServices.Marshal.PtrToStringAnsi(tmpp2);
			  if(tmpp2 != System.IntPtr.Zero) storj_uplinkPINVOKE.free_string(tmpp2);
    }
  }

  public static DownloaderRef download(BucketRef p0, string p1, out string p2) {
global::System.IntPtr tmpp2=global::System.IntPtr.Zero;
    try {
      DownloaderRef ret = new DownloaderRef(storj_uplinkPINVOKE.download(BucketRef.getCPtr(p0), p1, ref tmpp2), true);
      if (storj_uplinkPINVOKE.SWIGPendingException.Pending) throw storj_uplinkPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } finally {
p2=global::System.Runtime.InteropServices.Marshal.PtrToStringAnsi(tmpp2);
			  if(tmpp2 != System.IntPtr.Zero) storj_uplinkPINVOKE.free_string(tmpp2);
    }
  }

  public static uint download_read(DownloaderRef p0, SWIGTYPE_p_uint8_t p1, uint p2, out string p3) {
global::System.IntPtr tmpp3=global::System.IntPtr.Zero;
    try {
      uint ret = storj_uplinkPINVOKE.download_read(DownloaderRef.getCPtr(p0), SWIGTYPE_p_uint8_t.getCPtr(p1), p2, ref tmpp3);
      if (storj_uplinkPINVOKE.SWIGPendingException.Pending) throw storj_uplinkPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } finally {
p3=global::System.Runtime.InteropServices.Marshal.PtrToStringAnsi(tmpp3);
			  if(tmpp3 != System.IntPtr.Zero) storj_uplinkPINVOKE.free_string(tmpp3);
    }
  }

  public static void download_close(DownloaderRef p0, out string p1) {
global::System.IntPtr tmpp1=global::System.IntPtr.Zero;
    try {
      storj_uplinkPINVOKE.download_close(DownloaderRef.getCPtr(p0), ref tmpp1);
      if (storj_uplinkPINVOKE.SWIGPendingException.Pending) throw storj_uplinkPINVOKE.SWIGPendingException.Retrieve();
    } finally {
p1=global::System.Runtime.InteropServices.Marshal.PtrToStringAnsi(tmpp1);
			  if(tmpp1 != System.IntPtr.Zero) storj_uplinkPINVOKE.free_string(tmpp1);
    }
  }

  public static void download_cancel(DownloaderRef p0, out string p1) {
global::System.IntPtr tmpp1=global::System.IntPtr.Zero;
    try {
      storj_uplinkPINVOKE.download_cancel(DownloaderRef.getCPtr(p0), ref tmpp1);
      if (storj_uplinkPINVOKE.SWIGPendingException.Pending) throw storj_uplinkPINVOKE.SWIGPendingException.Retrieve();
    } finally {
p1=global::System.Runtime.InteropServices.Marshal.PtrToStringAnsi(tmpp1);
			  if(tmpp1 != System.IntPtr.Zero) storj_uplinkPINVOKE.free_string(tmpp1);
    }
  }

  public static void delete_object(BucketRef p0, string p1, out string p2) {
global::System.IntPtr tmpp2=global::System.IntPtr.Zero;
    try {
      storj_uplinkPINVOKE.delete_object(BucketRef.getCPtr(p0), p1, ref tmpp2);
      if (storj_uplinkPINVOKE.SWIGPendingException.Pending) throw storj_uplinkPINVOKE.SWIGPendingException.Retrieve();
    } finally {
p2=global::System.Runtime.InteropServices.Marshal.PtrToStringAnsi(tmpp2);
			  if(tmpp2 != System.IntPtr.Zero) storj_uplinkPINVOKE.free_string(tmpp2);
    }
  }

  public static void free_uploader(UploaderRef p0) {
    storj_uplinkPINVOKE.free_uploader(UploaderRef.getCPtr(p0));
    if (storj_uplinkPINVOKE.SWIGPendingException.Pending) throw storj_uplinkPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void free_downloader(DownloaderRef p0) {
    storj_uplinkPINVOKE.free_downloader(DownloaderRef.getCPtr(p0));
    if (storj_uplinkPINVOKE.SWIGPendingException.Pending) throw storj_uplinkPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void free_upload_opts(UploadOptions p0) {
    storj_uplinkPINVOKE.free_upload_opts(UploadOptions.getCPtr(p0));
  }

  public static void free_object_meta(ObjectMeta p0) {
    storj_uplinkPINVOKE.free_object_meta(ObjectMeta.getCPtr(p0));
  }

  public static void free_object_info(ObjectInfo p0) {
    storj_uplinkPINVOKE.free_object_info(ObjectInfo.getCPtr(p0));
  }

  public static void free_list_objects(ObjectList p0) {
    storj_uplinkPINVOKE.free_list_objects(ObjectList.getCPtr(p0));
  }

  public static ProjectRef open_project(UplinkRef p0, string p1, APIKeyRef p2, out string p3) {
global::System.IntPtr tmpp3=global::System.IntPtr.Zero;
    try {
      ProjectRef ret = new ProjectRef(storj_uplinkPINVOKE.open_project(UplinkRef.getCPtr(p0), p1, APIKeyRef.getCPtr(p2), ref tmpp3), true);
      if (storj_uplinkPINVOKE.SWIGPendingException.Pending) throw storj_uplinkPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } finally {
p3=global::System.Runtime.InteropServices.Marshal.PtrToStringAnsi(tmpp3);
			  if(tmpp3 != System.IntPtr.Zero) storj_uplinkPINVOKE.free_string(tmpp3);
    }
  }

  public static SWIGTYPE_p_uint8_t project_salted_key_from_passphrase(ProjectRef p0, string p1, out string p2) {
global::System.IntPtr tmpp2=global::System.IntPtr.Zero;
    try {
      global::System.IntPtr cPtr = storj_uplinkPINVOKE.project_salted_key_from_passphrase(ProjectRef.getCPtr(p0), p1, ref tmpp2);
      SWIGTYPE_p_uint8_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_uint8_t(cPtr, false);
      if (storj_uplinkPINVOKE.SWIGPendingException.Pending) throw storj_uplinkPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } finally {
p2=global::System.Runtime.InteropServices.Marshal.PtrToStringAnsi(tmpp2);
			  if(tmpp2 != System.IntPtr.Zero) storj_uplinkPINVOKE.free_string(tmpp2);
    }
  }

  public static void close_project(ProjectRef p0, out string p1) {
global::System.IntPtr tmpp1=global::System.IntPtr.Zero;
    try {
      storj_uplinkPINVOKE.close_project(ProjectRef.getCPtr(p0), ref tmpp1);
      if (storj_uplinkPINVOKE.SWIGPendingException.Pending) throw storj_uplinkPINVOKE.SWIGPendingException.Retrieve();
    } finally {
p1=global::System.Runtime.InteropServices.Marshal.PtrToStringAnsi(tmpp1);
			  if(tmpp1 != System.IntPtr.Zero) storj_uplinkPINVOKE.free_string(tmpp1);
    }
  }

  public static void free_string(out string p0) {
global::System.IntPtr tmpp0=global::System.IntPtr.Zero;
    try {
      storj_uplinkPINVOKE.free_string(tmpp0);
    } finally {
p0=global::System.Runtime.InteropServices.Marshal.PtrToStringAnsi(tmpp0);
			  if(tmpp0 != System.IntPtr.Zero) storj_uplinkPINVOKE.free_string(tmpp0);
    }
  }

  public static byte internal_UniverseIsEmpty() {
    byte ret = storj_uplinkPINVOKE.internal_UniverseIsEmpty();
    return ret;
  }

  public static UplinkRef new_uplink(UplinkConfig p0, out string p1) {
global::System.IntPtr tmpp1=global::System.IntPtr.Zero;
    try {
      UplinkRef ret = new UplinkRef(storj_uplinkPINVOKE.new_uplink(UplinkConfig.getCPtr(p0), ref tmpp1), true);
      if (storj_uplinkPINVOKE.SWIGPendingException.Pending) throw storj_uplinkPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } finally {
p1=global::System.Runtime.InteropServices.Marshal.PtrToStringAnsi(tmpp1);
			  if(tmpp1 != System.IntPtr.Zero) storj_uplinkPINVOKE.free_string(tmpp1);
    }
  }

  public static void close_uplink(UplinkRef p0, out string p1) {
global::System.IntPtr tmpp1=global::System.IntPtr.Zero;
    try {
      storj_uplinkPINVOKE.close_uplink(UplinkRef.getCPtr(p0), ref tmpp1);
      if (storj_uplinkPINVOKE.SWIGPendingException.Pending) throw storj_uplinkPINVOKE.SWIGPendingException.Retrieve();
    } finally {
p1=global::System.Runtime.InteropServices.Marshal.PtrToStringAnsi(tmpp1);
			  if(tmpp1 != System.IntPtr.Zero) storj_uplinkPINVOKE.free_string(tmpp1);
    }
  }

}

}
