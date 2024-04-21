using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using lap2.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.EntityFrameworkCore;

namespace lap2.Models
{
    public class Student
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? lname { get; set; }
        public int age { get; set; }
        [ForeignKey("dept")]
        public int did { get; set; }
        public virtual Department ?dept { get; set; }

    }


}
