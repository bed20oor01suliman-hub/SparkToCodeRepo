using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreProject.Models
{
    public class Project
    {
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public string ProjectLocation { get; set; }
        //Employee relation
        //M[EMP] => M[PRO] == Third table create by the Database by it self
        //if only in the relationship there is no attribute

        //public List<Employee> Employees { get; set; }

        //1 [Project] => M [EmpProj]
        public List<EmpProj> empProjs { get; set; } //many


    }
}
