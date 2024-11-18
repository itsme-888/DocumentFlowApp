using DataAccess;
using Microsoft.EntityFrameworkCore;
using DocumentFlowApp.Common.Entities;

namespace DocumentFlowApp.DataAccess.Repositories
{
    public class NotificationRepository(AppDbContext context)
    {
        public async Task NotificateAllUsers(string message)
        {
            var userIds = await context.Users
                .Select(x => x.Id)
                .ToArrayAsync();

            var notifications = userIds
                .Select(x => new Notification
                {
                    Message = message,
                    UserId = x,
                });

            await context.Notifications.AddRangeAsync(notifications);
            await context.SaveChangesAsync();
        }

        public async Task NotificateAdminUsers(string message)
        {
            var userIds = await context.Users
                .Where(x => x.IsAdmin)
                .Select(x => x.Id)
                .ToArrayAsync();

            var notifications = userIds
                .Select(x => new Notification
                {
                    Message = message,
                    UserId = x,
                });

            await context.Notifications.AddRangeAsync(notifications);
            await context.SaveChangesAsync();
        }

        public async Task NotificateNotAdminUsers(string message)
        {
            var userIds = await context.Users
                .Where(x => !x.IsAdmin)
                .Select(x => x.Id)
                .ToArrayAsync();

            var notifications = userIds
                .Select(x => new Notification
                {
                    Message = message,
                    UserId = x,
                });

            await context.Notifications.AddRangeAsync(notifications);
            await context.SaveChangesAsync();
        }

        public async Task NotificateUser(string message, long userId)
        {
            var notification = new Notification { Message = message, UserId = userId };

            await context.Notifications.AddAsync(notification);
            await context.SaveChangesAsync();
        }

        public async Task<List<Notification>> GetAllNotificationForUser(long UserId)
        {
            var result = await context.Notifications
                .Where(x => x.UserId == UserId)
                .OrderBy(x => x.IsRead)
                .ThenByDescending(x => x.CreatedDateTime)
                .ToListAsync();
            return result;
        }

        public async Task<int> GetUnreadNotificationCount(long UserId)
            => await context.Notifications
            .Where(x => x.UserId == UserId && !x.IsRead)
            .CountAsync();

        public async Task MarkAsReadNotification(long notificationId = 0)
        {
            var notification = await context.Notifications
                .FirstAsync(x => x.Id == notificationId);

            notification.IsRead = true;
            notification.DateTimeRead = DateTime.UtcNow;
            await context.SaveChangesAsync();
        }

        public async Task MarkAsReadAllNotification(long userId)
        {
            var notifications = await context.Notifications
                .Where(x => x.UserId == userId && !x.IsRead)
                .ToArrayAsync();

            foreach (var notification in notifications)
            {
                notification.IsRead = true;
                notification.DateTimeRead = DateTime.UtcNow;
            }
            await context.SaveChangesAsync();
        }
    }
}
