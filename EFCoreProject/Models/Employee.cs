using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreProject.Models
{
    public class Employee
    {
        public int EmployeeID {  get; set; }
        public int EmployeeSSN {  get; set; }
        public string EmployeeName { get; set; }
        public int EmployeeAge { get; set; }
        public double EmployeeSalary { get; set; }
    }
}
