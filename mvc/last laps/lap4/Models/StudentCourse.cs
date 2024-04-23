using System.ComponentModel.DataAnnotations.Schema;

namespace lap4.Models
{
    public class StudentCourse
    {
        [ForeignKey("Student")]
        public int StudentId { get; set; }
        [ForeignKey("Course")]
        public int CrsId { get; set; }
        public int Degree { get; set; }
        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
