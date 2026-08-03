using EFCoreProject.Models;

namespace EFCoreProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ProjectContext context = new ProjectContext();
            using (var context = new ProjectContext())//نحطها داخل ايطار
            {
                //add data on employees table
                //e1.EmpName = "Badour";
                //e1.EmployeeSalary = 1000;
                //e1.EmployeeSSN = 262018;
                //e1.EmployeeAge = 24;

                //context.employees.Add(e1);//خطوة العمل
                //context.SaveChanges();//خطوة التأكيد 

                ////Case1: Register User
                //Console.WriteLine("Register User : ");
                //Employee e1 = new Employee();

                //Console.WriteLine("Enter employee name : ");
                //e1.EmpName = Console.ReadLine();

                //Console.WriteLine("Enter employee salary : ");
                //e1.EmployeeSalary = double.Parse(Console.ReadLine());

                //Console.WriteLine("Enter employee SSN : ");
                //e1.EmployeeSSN = int.Parse(Console.ReadLine());

                //Console.WriteLine("Enter employee age : ");
                //e1.EmployeeAge = int.Parse(Console.ReadLine());

                //context.employees.Add(e1);//خطوة العمل
                //context.SaveChanges();//خطوة التأكيد

                //Case2: Delete employee
                //Console.WriteLine("Enter Employee ID to Delete : ");
                //int id = int.Parse(Console.ReadLine());
                //Employee employee = context.employees.FirstOrDefault(e => e.EmployeeID == id);
                //if (employee == null)
                //{
                //    Console.WriteLine("Employee not found");
                //}
                //else
                //{
                //    context.employees.Remove(employee);
                //    context.SaveChanges();
                //}

                //Case3: update employee
                Console.WriteLine("Enter Employee ID to update : ");
                int idEmp = int.Parse(Console.ReadLine());
                Employee updEmployee = context.employees.FirstOrDefault(e => e.EmployeeID == idEmp);
                if (updEmployee == null)
                {
                    Console.WriteLine("Employee not found");
                }
                else
                {
                    Console.Write("Enter new employee name: ");
                    updEmployee.EmpName = Console.ReadLine();   

                    context.SaveChanges();   
                    Console.WriteLine("Employee name updated successfully.");
                }
            }

        }
    }
}
