namespace ProSync.Domain.Entities
{
    public class Client
    {
        public int ClientId { get; set; }
        public int UserId { get; set; }
        public string ClientName { get; set; }
        
        public virtual User User { get; set; }
    }
}
