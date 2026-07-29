using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreProject.Models
{
    [PrimaryKey(nameof(EmployeeID), nameof(ProjectID))]
    public class EmpProj //[Third table]
    {
        //key of 1 go to many
        [ForeignKey("emp")]
        public int EmployeeID { get; set; }

        //1 [Employee] => M [EmpProj]
        public Employee emp {  get; set; } //1 

        /////////////////

        //key of 1 go to many
        [ForeignKey("pro")]
        public int ProjectID { get; set; }
        //1 [Project] => M [EmpProj]
        public Project pro { get; set; } //1

        //attribut in relationship digram add to the third table
        public int Hours { get; set; }

    }
}
