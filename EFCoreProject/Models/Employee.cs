using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreProject.Models
{
    public class Employee
    {
        public int EmployeeID {  get; set; }
        public int EmployeeSSN {  get; set; }
        public string EmpName { get; set; }
        public int EmployeeAge { get; set; }
        public double EmployeeSalary { get; set; }

        //Works for
        //1-M
        [ForeignKey("D")]
        public int DepartmentID { get; set; } //1,2,3

        public Department D {  get; set; }
        //Dependent relation
        //1-1
        public Dependent Dep { get; set; }
    }
}
