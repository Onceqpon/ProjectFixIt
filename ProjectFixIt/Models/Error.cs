namespace ProjectFixIt.Models
{
    public class Error
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ErrorMessage { get; set; }
        public string WorkerFound { get; set; }
        public string RepairStatus { get; set; }
        public DateTime FoundDate { get; set; }


    }
}
