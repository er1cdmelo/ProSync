namespace ProSync.Domain.Entities
{
    public class Project
    {
        public int ProjectId { get; set; }
        public int ProfessionalId { get; set; }
        public int? ClientId { get; set; }
        public string Title { get; set; } 
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public virtual Professional Professional { get; set; }
        public virtual Client Client { get; set; }
    }
}
