using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp83
{
    internal struct Department
    {
        //fields
        string deptname;
        string manger;
        int deptID;
        employee[] employees;

        //properties
        public string Deptname
        {
            get { return deptname; }
            set { deptname = value; }
        }
        public string Manger
        {
            get { return manger; }
            set { manger = value; }
        }
        public int DeptID
        {
            get { return deptID; }
            set { deptID = value; }
        }
        public employee[] Employees
        {
            get { return employees; }
            set { employees = value; }
        }
        // get , set 
        public void setDeptName(string _deptname)
        { deptname = _deptname; }
        public string GetDeptName()
        { return deptname; }
        public void SetManger(string _manger)
        { manger = _manger; }
        public string GetManger()
        { return manger; }
        public void SetID(int _id)
        { deptID = _id; }
        public int GetID()
        { return deptID; }
        public void SetName(string _name)
        { deptname = _name; }
        public string GetName()
        { return deptname; }
        public void SetEmployee(employee[] _employees)
        { employees = _employees; }
        public employee[] GetEmployee()
        { return employees; }
        //constructor
        public Department(string _deptname, string _manger, int _deptID, employee[] _employees)
        {
            deptname = _deptname; manger = _manger; deptID = _deptID; employees = _employees;
        }
        //print method
        // get data
        public string GetEmployeeData(int _empID)
        {
            for(int i =0; i<employees.Length; i++)
            {
                if(employees[i].Id == _empID)
                {
                    return $"employee with ID {_empID} " +
                        $"found with : Security level = {employees[i].Security_level} " +
                        $", salery = {employees[i].Salery} ," +
                        $" hiredate = {employees[i].Hd} , gender = {employees[i].Gender}"; 
                }
            }
            return $"employee With ID {_empID} Not Found";

        }
        public void Print()
        { 

            // add for loop print employee
            Console.WriteLine($"Department data: Dept name: {deptname} ," +
                $"Manger: {manger}, deptid : {deptID} ");
            Console.WriteLine("Employees");
            for(int i =0; i<employees.Length; i++)
            {
                employees[i].print();
            }
        }
    }
}
