using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap_consumer
{
    //internal class student
    //{
    //    public int studentID { get; set; }
    //    public string? fullname { get; set; }
    //    public int age { get; set; }
    //    public string? supervisorName { get; set; }
    //    public string departmentName { get; set; }


    //}

    internal class student
    {
        public int id { get; set; }
        public string? name { get; set; }
        public int age { get; set; }
        public string? supervisorName { get; set; }

        public int deptid { get; set; }
    }
}
