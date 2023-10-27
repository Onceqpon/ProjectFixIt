namespace ProjectFixIt.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string WorkerName { get; set; }
        public string Piority { get; set; }
        public DateTime NotificationDate { get; set; }
    }
}
