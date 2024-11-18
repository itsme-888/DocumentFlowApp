namespace DocumentFlowApp.Common.Entities
{
    public class Notification : IBaseEntity
    {
        public long Id { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime? UpdatedDateTime { get; set; }

        public string Message { get; set; } = null!;

        public long UserId { get; set; }
        public User User { get; set; } = null!;

        public bool IsRead { get; set; }

        public DateTime? DateTimeRead { get; set; }
    }
}
