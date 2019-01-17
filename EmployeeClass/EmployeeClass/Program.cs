using System;

namespace EmployeeClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä on työntekijä ohjelma\n\n");
            Employee[] employees = new Employee[3];
            employees[0] = new Employee("Pekka", 1, "myyntipäällikkö", 3500);
            employees[1] = new Employee("Matti", 1, "pomo", 5500);
            employees[2] = new Employee("Marja", 1, "sihteeri", 2500);
            Console.WriteLine(employees[0].PrintEmployeeInfo());
            Console.WriteLine(employees[1].PrintEmployeeInfo());
            Console.WriteLine(employees[2].PrintEmployeeInfo());
            Console.WriteLine(employees[0].CompareSalary(employees[1]));
            Console.WriteLine(employees[1].CompareSalary(employees[2]));
            Console.WriteLine(employees[2].CompareSalary(employees[0]));
            Console.ReadKey();
        }
    }
}
