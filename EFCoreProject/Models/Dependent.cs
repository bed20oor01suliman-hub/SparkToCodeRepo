using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreProject.Models
{
    public class Dependent
    {
        public int DependentID { get; set; } 
        public string DependentName { get; set; }
        public string Relationship { get; set; }
        //Employee relation
        //only for uderstanding purpose not correct
        //[1] Dep => [1] Emp //Relationship we make any of tables PK as forgein key in another table
        //in 1 to 1 relationship
        [ForeignKey("Emp")]
        public int EmployeeID { get; set; }

        public Employee Emp {  get; set; }
    }
}
