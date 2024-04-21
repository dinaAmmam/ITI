namespace lap2.Models
{
    public class Department
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? supervisorName { get; set; }
        public string ?loc { get; set; }
        public virtual List<Student> students { get; set; } = new List<Student>();
    }
}
