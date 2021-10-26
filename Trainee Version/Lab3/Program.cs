using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Emp = new Employee();

            StoreData(Emp);


            ShowData(Emp);

     
            Console.Read();
        }

        static void StoreData(Employee Emp)
        {
            Console.WriteLine("Enter employee ID");
            Emp.Employee_ID=CustomConsole.ReadString();
            Console.WriteLine("Enter employee name:");
            Emp.Name=CustomConsole.ReadString();
            Console.WriteLine("Enter employee gender:");
            Emp.Gender=CustomConsole.ReadString();
            Emp.AddAddress();
           
            
        }

        static void ShowData(Employee Emp)
        {
            //----------------Display the employee information
            Console.WriteLine("Employee Id : "+Emp.Employee_ID);

            Console.WriteLine("Employee Name : "+Emp.Name);
            Console.WriteLine("Employee Gender : "+Emp.Gender);
            Emp.GetAddress();
            //Console.WriteLine("Employee Address : --------------");
            Console.WriteLine("Address 1 : "+Emp.Address1);
            Console.WriteLine("Address 2 : "+Emp.Address2);
            Console.WriteLine("City : "+Emp.City);
            Console.WriteLine("PinCode : "+Emp.PinCode);
            Console.WriteLine("----------------------------------");

        }
    }
}
