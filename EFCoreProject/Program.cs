using EFCoreProject.Models;

namespace EFCoreProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProjectContext context = new ProjectContext();
            //add data on employees table
            Employee e1 = new Employee();
            e1.EmpName = "Badour";
            e1.EmployeeSalary = 1000;
            e1.EmployeeSSN = 262018;
            e1.EmployeeAge = 24;
            context.employees.Add(e1);//خطوة العمل
            context.SaveChanges();//خطوة التأكيد
        }
    }
}
