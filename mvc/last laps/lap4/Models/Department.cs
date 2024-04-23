using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace lap4.Models
{
    public class Department
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name ="Department Id")]
        public int DeptId { get; set; }
        [Display(Name = "Department Name")]
        public string DeptName { get; set; }
        public bool Status { get; set; } = true;
        public ICollection<Student> students { get; set; } = new HashSet<Student>();
        public List<Course> courses { get; set; }

    }
}
