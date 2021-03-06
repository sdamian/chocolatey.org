﻿
namespace NuGetGallery
{
    public interface IConfiguration
    {
       
        string AzureStorageAccessKey { get; }
        string AzureStorageAccountName { get; }
        string AzureStorageBlobUrl { get; }
        string FileStorageDirectory { get; }
        PackageStoreType PackageStoreType { get; }

        string GetSiteRoot(bool useHttps);

        string S3Bucket { get; }
        string S3AccessKey { get; }
        string S3SecretKey { get; }
        bool SmtpEnableSsl { get; }
    }
}