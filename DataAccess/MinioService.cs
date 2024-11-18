using DocumentFlowApp.Common;
using DocumentFlowApp.Common.Dtos;
using DocumentFlowApp.Common.Entities;
using Microsoft.Extensions.Configuration;
using Minio;
using Minio.DataModel.Args;

namespace DocumentFlowApp.DataAccess
{
    public class MinioService
    {
        private readonly IMinioClient _minioClient;
        private const string _bucketName = "default";

        public MinioService(IConfiguration configuration)
        {
            var config = configuration.Get<AppConfig>();

            _minioClient = new MinioClient()
            .WithEndpoint(config.MinioUrl)
                .WithCredentials(config.MinioUser, config.MinioPass)
            .Build();

            Task.Run(() => EnsureBucketExistsAsync());
        }

        private async Task EnsureBucketExistsAsync()
        {
            var exists = await _minioClient.BucketExistsAsync(new BucketExistsArgs().WithBucket(_bucketName));

            if (!exists)
            {
                await _minioClient.MakeBucketAsync(new MakeBucketArgs().WithBucket(_bucketName));
            }
        }

        public async Task<string> UploadFile(FileUploadDto fileUploadDto)
        {
            var contentType = string.Empty;

            if (MimeTypes.TryGetMimeType($"{fileUploadDto.FileName + fileUploadDto.FileExt}", out var mimeType))
            {
                contentType = mimeType;
            }

            var objName = Guid.NewGuid().ToString() + fileUploadDto.FileExt;

            var putObj = new PutObjectArgs()
                .WithBucket(_bucketName)
                .WithFileName(fileUploadDto.FullPath)
                .WithObject(objName)
                .WithContentType(contentType);

            var result = await _minioClient.PutObjectAsync(putObj);
            return objName;
        }

        public async Task DownloadFile(FileInfoDb fileInfoDb, string folderForSave)
        {
            var currentDateTime = DateTime.Now.ToString("dd_MM_yyyy_HH_mm_d_");
            var pathToSave = Path.Combine(folderForSave, currentDateTime + fileInfoDb.Name + fileInfoDb.Ext);

            var getObjArgs = new GetObjectArgs()
                .WithBucket(_bucketName)
                .WithObject(fileInfoDb.MinioPath)
                .WithFile(pathToSave);

            await _minioClient.GetObjectAsync(getObjArgs);
        }
    }
}
