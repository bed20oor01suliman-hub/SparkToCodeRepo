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

        //Dependent relation
        //1-1
        public Dependent Dep { get; set; }

        //Project relation
        //M[EMP] => M[PRO] == Third table create by the Database by it self
        //if only in the relationship there is no attribute
        //public List<Project> Projects { get; set; }

        //1 [Employee] => M [EmpProj]
        public List<EmpProj> empProjs { get; set; } //many




        //Works for
        //1-M
        [ForeignKey("D")]
        public int DepartmentID { get; set; } //1,2,3
        public Department D { get; set; }

        //manage 1-1
        //employee is partial so its key go to the total which is department
        [InverseProperty("ManagEmp")]
        public Department ManagDep { get; set; } //1 relationship
    }
}
