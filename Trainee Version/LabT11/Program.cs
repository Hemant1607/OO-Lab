using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabT11
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Employee[] Employees = new Employee[4];
            //Employee emp = null;

            string EmpId, Name, ReportDate;
            double AllowancePercentage, Basic, HRA;
            int Role;

        
            Console.WriteLine("Enter employee information");

            for (int i = 0; i < Employees.Length; i++)
            {
                Employee emp = new Employee();
                Console.WriteLine("Employee No : " + (i+1));
                Console.Write("Id : ");
                EmpId = CustomConsole.ReadString();
                emp.EmpId=EmpId;
                Console.Write("Name : ");
                Name = CustomConsole.ReadString();
                emp.Name=Name;
                Console.Write("Basic : ");
                Basic = CustomConsole.ReadDouble();
                emp.Basic=Basic;
                Console.Write("HRA : ");
                HRA = CustomConsole.ReadDouble();
                emp.HRA=HRA;
                Console.Write("Percentage of Allowance : ");
                AllowancePercentage = CustomConsole.ReadDouble();
                emp.AllowancePercentage=AllowancePercentage;


                Console.WriteLine("Enter Role Id : ");
                Console.WriteLine((int)Roles.DEVELOPER + ". " + RoleBuilder.GetRoleDescription((int)Roles.DEVELOPER));
                Console.WriteLine((int)Roles.TEST_ENGINEER + ". " + RoleBuilder.GetRoleDescription((int)Roles.TEST_ENGINEER));
                Console.WriteLine((int)Roles.SR_DEVELOPER + ". " + RoleBuilder.GetRoleDescription((int)Roles.SR_DEVELOPER));
                Console.WriteLine((int)Roles.DESIGNER + ". " + RoleBuilder.GetRoleDescription((int)Roles.DESIGNER));
                Role = CustomConsole.ReadInt();
                emp.Role=Role;
                Employees[i]=emp;

                
            }

            Console.Write("Enter the date of the report (dd/mm/yyyy) : ");
            ReportDate = CustomConsole.ReadString();

            EmployeeReport Report = new EmployeeReport(ReportDate);
            //Report.ReportDate = ReportDate;

            Report.DisplayEmployees(Employees);

            Console.ReadLine();

        }
    }
}
