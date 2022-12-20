namespace HomeworkHelper.Models
{
    public class Assignments
    {
        public int ID { get; set; }
        public string? ClassName { get; set; }
        public string? AssignmentName { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime RemindMe { get; set; }
    }
}
