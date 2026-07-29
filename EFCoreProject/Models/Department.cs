using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreProject.Models
{
    public class Department
    {
        public int DepartmentID { get; set; } //1,2,3
        public int DepartmentNumber { get; set; } //10,20,30
        public string DepartmentName { get; set; }


        //1{DEP} => M {EMP}
        //1{DEP} => 1 {EMP}
        //------------------
        //1      =>  M
        //Works for
        //1-M
        [InverseProperty("D")]
        public List<Employee> Employees { get; set; }


        //manage 1-1
        [ForeignKey("ManagEmp")]
        public int EmployeeID { get; set; }//id of patial[emp] put in total[dep]

        public Employee ManagEmp {  get; set; }

    }
}
