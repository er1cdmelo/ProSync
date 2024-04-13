namespace ProSync.Domain.Entities
{
    public class Professional
    {
        public int ProfessionalId { get; set; }
        public string ProfessionalName { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
