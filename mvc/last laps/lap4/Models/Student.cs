using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace lap4.Models
{
    public class Student
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [Required(ErrorMessage ="*")]
        [StringLength(10, MinimumLength =3, ErrorMessage = "violate stringlength ct")]
        [Display(Name="Full Name")]
        public string Name { get; set; }
        [Range(20, 30, ErrorMessage = "range validator")]
        public int Age { get; set; }
        [Required(ErrorMessage = "*")]
        [RegularExpression(@"[a-zA-Z0-9]+@[a-zA-Z]+.[a-zA-Z]{2,4}")]
        [Remote("CheckEmail", "Student" , AdditionalFields ="Name,Age")]
        public string Email { get; set; }
        [NotMapped]
        [Compare("Email")]
        public string ConfirmEmail { get; set; }
        public string  Image { get; set; } 
        [ForeignKey("Department")]
        public int? DeptNo { get; set; }

        public Department Department { get; set; }
        public List<StudentCourse> StudentCourses { get; set; }


    }
}
