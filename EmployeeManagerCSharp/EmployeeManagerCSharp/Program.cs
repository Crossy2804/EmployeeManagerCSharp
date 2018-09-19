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
            Employee emp1 = new Employee(123, "Bob");
            Console.WriteLine(emp1.printDetails());

            Console.ReadLine();
        }
    }
}
