using DataAccess;
using DocumentFlowApp.Common.Dtos;
using DocumentFlowApp.Common.Entities;
using Microsoft.EntityFrameworkCore;

namespace DocumentFlowApp.DataAccess.Repositories
{
    public class RequestRepository(AppDbContext context)
    {
        public async Task ChangeRequest(long requestId, string message, List<long> fileIds)
        {
            var request = await context.FileRequests.SingleAsync(x => x.Id == requestId);
            request.Message = message;
            request.RequestStatus = Common.Enums.RequestStatusEnum.Fixed;

            var oldAttachedFilesToRequest = await context.AttachedFilesToRequests
                .Where(x => x.FileRequestId == requestId)
                .ToArrayAsync();

            var toRemove = oldAttachedFilesToRequest.Where(x => !fileIds.Contains(x.FileInfoId));

            context.AttachedFilesToRequests.RemoveRange(toRemove);

            var attachedFilesToRequest = fileIds
                .Where(x => !oldAttachedFilesToRequest.Select(y => y.FileInfoId).Contains(x))
                .Select(x => new AttachedFilesToRequest
            {
                FileInfoId = x,
                FileRequestId = request.Id,
            }).ToArray();

            await context.AddRangeAsync(attachedFilesToRequest);
            await context.SaveChangesAsync();
        }

        public async Task<long> AddNewRequest(string message, long userId, List<long> fileIds)
        {
            var request = new FileRequest
            {
                Message = message,
                CreatedByUserId = userId,
                RequestStatus = Common.Enums.RequestStatusEnum.New,
            };

            await context.FileRequests.AddAsync(request);
            await context.SaveChangesAsync();

            var attachedFilesToRequest = fileIds.Select(x => new AttachedFilesToRequest 
            { 
                FileInfoId = x,
                FileRequestId = request.Id,
            }).ToArray();

            await context.AddRangeAsync(attachedFilesToRequest);
            await context.SaveChangesAsync();
            return request.Id;
        }

        public async Task<List<RequestDto>> GetOpenRequestsForUser(long userId)
        {
            var data = await context.FileRequests
                .Where(x => x.CreatedByUserId == userId)
                .Where(x => x.RequestStatus != Common.Enums.RequestStatusEnum.Approved)
                .OrderByDescending(x => x.UpdatedDateTime)
                .Select(x => new RequestDto
                {
                    Id = x.Id,
                    CreatedDateTime = x.CreatedDateTime,
                    UpdatedDateTime = x.UpdatedDateTime,
                    Message = x.Message,
                    SelectedFileCount = x.AttachedFilesToRequests.Count,
                    ApprovedUser = x.ApprovedByUser == null ? string.Empty : x.ApprovedByUser.Name,
                    SelectedFileIds = x.AttachedFilesToRequests.Select(x => x.FileInfoId).ToList(),
                    CreatedByUserName = x.CreatedByUser == null ? string.Empty : x.CreatedByUser.Name,
                    RequestStatus = x.RequestStatus,
                    Comment = x.CommentDecline == null ? string.Empty : x.CommentDecline,
                })
                .ToListAsync();

            return data;
        }

        public async Task<List<RequestDto>> GetRequestsForApprove()
        {
            var data = await context.FileRequests
                .Where(x => x.RequestStatus != Common.Enums.RequestStatusEnum.NeedEdit 
                && x.RequestStatus != Common.Enums.RequestStatusEnum.Approved)
                .OrderByDescending(x => x.UpdatedDateTime)
                .Select(x => new RequestDto
                {
                    Id = x.Id,
                    CreatedDateTime = x.CreatedDateTime,
                    UpdatedDateTime = x.UpdatedDateTime,
                    Message = x.Message,
                    SelectedFileCount = x.AttachedFilesToRequests.Count,
                    SelectedFileIds = x.AttachedFilesToRequests.Select(x => x.FileInfoId).ToList(),
                    ApprovedUser = x.ApprovedByUser == null ? string.Empty : x.ApprovedByUser.Name,
                    CreatedByUserName = x.CreatedByUser == null ? string.Empty : x.CreatedByUser.Name,
                    CreatedByUserId = x.CreatedByUserId,
                    RequestStatus = x.RequestStatus,
                    Comment = x.CommentDecline == null ? string.Empty : x.CommentDecline,
                })
                .ToListAsync();

            return data;
        }

        public async Task<List<RequestDto>> GetRequestsForUserHistory(long userId)
        {
            var data = await context.FileRequests
                .Where(x => x.CreatedByUserId == userId)
                .OrderByDescending(x => x.UpdatedDateTime)
                .Select(x => new RequestDto
                {
                    Id = x.Id,
                    CreatedDateTime = x.CreatedDateTime,
                    UpdatedDateTime = x.UpdatedDateTime,
                    Message = x.Message,
                    SelectedFileCount = x.AttachedFilesToRequests.Count,
                    ApprovedUser = x.ApprovedByUser == null ? string.Empty : x.ApprovedByUser.Name,
                    RequestStatus = x.RequestStatus,
                    Comment = x.CommentDecline == null ? string.Empty : x.CommentDecline,
                })
                .ToListAsync();

            return data;
        }

        public async Task ApproveRequest(long requestId, long approvedBy)
        {
            var req = await context.FileRequests
                .SingleAsync(x => x.Id == requestId);

            req.RequestStatus = Common.Enums.RequestStatusEnum.Approved;
            req.ApprovedByUserId = approvedBy;
            await context.SaveChangesAsync();
        }

        public async Task DeclineRequest(long requestId, string comment, long approvedBy)
        {
            var req = await context.FileRequests
                .SingleAsync(x => x.Id == requestId);

            req.RequestStatus = Common.Enums.RequestStatusEnum.NeedEdit;
            req.CommentDecline = comment;
            req.ApprovedByUserId = approvedBy;
            await context.SaveChangesAsync();
        }
    }
}
