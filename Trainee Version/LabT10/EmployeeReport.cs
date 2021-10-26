using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabT10
{
    class EmployeeReport
    {
       
        public string ReportDate { get; set; }
	
	    private void PrintLine() 
        {
		    Console.WriteLine("---------------------------------------------------------------------------");
	    }

	    private void DisplayHeader() 
        {
		    PrintLine();
		    Console.WriteLine("EMPLOYEE REPORT\t\t\t\t");
		    Console.WriteLine("Date : " + ReportDate);
		    PrintLine();
	    }

      
	    private void DisplayFooter(int Count) {
		    PrintLine();
		    Console.WriteLine("Total Employees : " + Count);
		    PrintLine();
	    }

   
	    public void DisplayEmployees(Employee[] Employees) 
        {
		    DisplayHeader();

            Console.WriteLine("EMP_ID\tNAME\tROLE\t\tBASIC\tHRA\tALLOW\tSALARY");
			PrintLine();
			for (int i = 0; i < 4; i++)
			{
				Console.Write(Employees[i].EmpId+"\t");
				Console.Write(Employees[i].Name+"\t");
				Console.Write(RoleBuilder.GetRoleDescription(Employees[i].Role)+"\t");
				Console.Write(Employees[i].Basic+"\t");
				Console.Write(Employees[i].HRA+"\t");
				Console.Write(Employees[i].GetAllowance(Employees[i])+"\t");
				Console.Write(Employees[i].GetSalary(Employees[i])+"\t");
				Console.WriteLine("");
			}
            PrintLine();

    		
    		
    		//DisplayFooter(Employees.Length);
	    }
    }
}
