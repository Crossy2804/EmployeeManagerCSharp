using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagerCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager emp1 = new Manager(1712, "Ian");
            //Console.WriteLine(emp1.PrintDetails());
            Employee emp2 = new Employee(1402, "Tina");
            Employee emp3 = new Employee(1808, "Julian");
            Employee emp4 = new Employee(2911, "Emma");
            Employee emp5 = new Employee(2804, "Sophie");
            Employee emp6 = new Employee(2006, "Cheech");
            emp1.AddEmployee(emp2);
            emp1.AddEmployee(emp3);
            emp1.AddEmployee(emp4);
            emp1.AddEmployee(emp5);
            emp1.AddEmployee(emp6);
            Console.WriteLine(emp1.PrintDetails());
            Console.ReadLine();
        }
    }
}
