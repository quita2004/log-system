namespace Core.Entities
{
    public class Logs
    {
        public long Id { get; set; }
        public string Data { get; set; }
        public DateTime Datetime { get; set; } = DateTime.Now;
    }
}
    