using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationPOC
{
    public class Employee
    {
        public string Name { get; set; }
        public Department EmpDepartment { get; set; }

        public Employee(string name, Department department)
        {
            Name = name;
            EmpDepartment = department;
        }

        
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee: {Name}, Department: {EmpDepartment}");
        }
    }
}
