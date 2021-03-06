using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabT10
{
    class Employee
    {
        public string EmpId { get; set; }
        public string Name { get; set; }
        public double Basic { get; set; }
        public double HRA { get; set; }
        public double AllowancePercentage { get; set; }
        public int Role { get; set; }
        public Employee(string EmpId,string Name,double Basic,double HRA,double AllowancePercentage,int Role)
        {
            this.EmpId=EmpId;
            this.Name=Name;
            this.HRA=HRA;
            this.Basic=Basic;
            this.AllowancePercentage=AllowancePercentage;
            this.Role=Role;
        }

        public double GetSalary(Employee emp)
        {
            return SalaryCalculator.GetSalary(emp);

        }
        
        public double GetAllowance(Employee emp)
        {
            return SalaryCalculator.GetAllowance(emp);

        }
        
    }
}
