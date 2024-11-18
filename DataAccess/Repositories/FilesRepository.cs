using DataAccess;
using DocumentFlowApp.Common.Dtos;
using DocumentFlowApp.Common.Entities;
using Microsoft.EntityFrameworkCore;

namespace DocumentFlowApp.DataAccess.Repositories
{
    public class FilesRepository(AppDbContext context, MinioService minioService)
    {
        public async Task UploadFileAsync(FileUploadDto fileUploadDto, long userId)
        {
            var minioObjGuid = await minioService.UploadFile(fileUploadDto);

            var fileInfo = new FileInfoDb
            {
                Name = fileUploadDto.FileName,
                Ext = fileUploadDto.FileExt,
                MinioPath = minioObjGuid,
                Description = fileUploadDto.UserDescriptions,
                IsArchived = false,
                IsSoftDeleted = false,
                UserId = userId,
                Size = fileUploadDto.FileSize,
            };

            context.FileInfos.Add(fileInfo);
            await context.SaveChangesAsync();
        }

        public async Task<FileInfoDb[]> GetFileInfos(User currentUser)
        {
            var fileInfos = await context.FileInfos
                .AsNoTracking()
                .Include(x => x.User)
                .Where(x => currentUser.IsAdmin
                || (x.UserId == currentUser.Id && !x.IsSoftDeleted && !x.IsArchived))
                .OrderByDescending(x => x.CreatedDateTime)
                .ToArrayAsync();
            return fileInfos!;
        }

        public async Task<FileInfoDb[]> GetFilesByRequest(long requestId)
        {
            var fileInfos = await context.AttachedFilesToRequests
                .Include(x => x.FileInfo)
                .ThenInclude(x => x.User)
                .Where(x => x.FileRequestId == requestId)
                .Select(x => x.FileInfo)
                .AsNoTracking()
                .OrderByDescending(x => x.CreatedDateTime)
                .ToArrayAsync();
            return fileInfos!;
        }

        public async Task SetArchive(long id, bool value)
        {
            var fileInfo = await context.FileInfos
                .SingleAsync(x => id == x.Id);

            fileInfo.IsArchived = value;
            await context.SaveChangesAsync();
        }

        public async Task SetDeleted(long id, bool value)
        {
            var fileInfo = await context.FileInfos
                .SingleAsync(x => id == x.Id);

            fileInfo.IsSoftDeleted = value;
            await context.SaveChangesAsync();
        }
    }
}
