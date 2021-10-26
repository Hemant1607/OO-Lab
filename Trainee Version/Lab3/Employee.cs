using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
   
    class Employee
    {
        public string Employee_ID { get;set;}
        public string Name { get;set;}
        public string Gender { get;set;}
        public string Address1;
        public string Address2;
        public string City;
        public int PinCode;
        Address add=new Address();
        
        public void AddAddress() 
        { 
        Console.WriteLine("Enter Address1:");
        add.Address1=CustomConsole.ReadString();
        Console.WriteLine("Enter Address2:");
        add.Address2=CustomConsole.ReadString();
        Console.WriteLine("Enter City:");
        add.City=CustomConsole.ReadString();
        Console.WriteLine("Enter Pin Code:");
        add.PinCode=CustomConsole.ReadInt();
        }
        public void GetAddress()
        {
            Address1=add.Address1;
            Address2=add.Address2;
            City=add.City;
            PinCode=add.PinCode;
        }

    }
}
