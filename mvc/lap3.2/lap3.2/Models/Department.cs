using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lap3._2.Models
{
    public class Department
    {
        [Key , DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public List<Student> students { get; set; }

    }
}
