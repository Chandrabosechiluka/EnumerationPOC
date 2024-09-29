
namespace EnumerationPOC
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Employee emp1 = new Employee("Chiluka", Department.HR);
            Employee emp2 = new Employee("Chandra", Department.IT);
            Employee emp3 = new Employee("Bose", Department.Sales);

            
            emp1.DisplayEmployeeInfo();
            emp2.DisplayEmployeeInfo();
            emp3.DisplayEmployeeInfo();

            
            Console.WriteLine("\n--- Department Specific Tasks ---");
            AssignDepartmentTasks(emp1.EmpDepartment);
            AssignDepartmentTasks(emp2.EmpDepartment);
            AssignDepartmentTasks(emp3.EmpDepartment);

            
            Console.WriteLine("\n--- List of Departments ---");
            foreach (var dept in Enum.GetValues(typeof(Department)))
            {
                Console.WriteLine(dept);
            }
        }

        public static void AssignDepartmentTasks(Department department)
        {
            switch (department)
            {
                case Department.HR:
                    Console.WriteLine("HR Department: Responsible for employee management and recruitment.");
                    break;
                case Department.IT:
                    Console.WriteLine("IT Department: Responsible for technical support and infrastructure.");
                    break;
                case Department.Sales:
                    Console.WriteLine("Sales Department: Responsible for driving sales and customer relationships.");
                    break;
                case Department.Finance:
                    Console.WriteLine("Finance Department: Responsible for managing company finances.");
                    break;
                default:
                    Console.WriteLine("Unknown Department.");
                    break;
            }
        }

    }
}
