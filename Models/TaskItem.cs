namespace TaskManagement.Models
{
    public class TaskItem
    {

        public int Id { get; set; } 

        public string TaskTitle { get; set; } = "";
        public string TaskDescription { get; set; } = "";
        public string Status { get; set; } = "";
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int CreatedById { get; set; }
        public string CreatedByName { get; set; } = "";
        public int UpdatedById { get; set; }
        public string UpdatedByName { get; set; } = "";
    }
}
