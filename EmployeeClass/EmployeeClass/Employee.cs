using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeClass
{
    class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
        private static int counter = 1;
        private string message = null;

        public Employee()
        {
            this.Name = System.String.Empty;
            this.Id = 0;
            this.Position = System.String.Empty;
            this.Salary = 0;
        }

        public Employee(string name, int id, string position, int salary)
        {
            this.Name = name;
            this.Id = counter++;
            this.Position = position;
            this.Salary = salary;
        }

        public string CompareSalary(Employee employee)
        {
            if (this.Salary > employee.Salary)
            {
                message = $"{this.Name} tienaa enemmän kuin {employee.Name}";
            }
            else if (this.Salary == employee.Salary)
            {
                message = $"{this.Name} tienaa yhtä paljon kuin {employee.Name}";
            }
            else
            {
                message = $"{employee.Name} tienaa enemmän kuin {this.Name}";
            }
            return message;
        }
        public string PrintEmployeeInfo()
        {
            return $"Työntekijä: {this.Name}, Id: {this.Id}, Tehtävä: {this.Position}, Palkka: {this.Salary}";
        }

    }
}
