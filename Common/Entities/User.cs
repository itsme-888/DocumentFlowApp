namespace DocumentFlowApp.Common.Entities
{
    public class User : IBaseEntity
    {
        public long Id { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime? UpdatedDateTime { get; set; }

        public required string UserName { get; set; } = null!;

        public required string Name { get; set; } = null!;

        public required string PasswordHash { get; set; } = null!;

        public bool IsAdmin { get; set; }
    }
}
