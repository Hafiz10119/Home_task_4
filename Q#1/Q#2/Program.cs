using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_2
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }

        public Employee(int employeeID, string name, string department, double salary)
        {
            EmployeeID = employeeID;
            Name = name;
            Department = department;
            Salary = salary;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"-----***Emplyee Details***-----");
            Console.WriteLine($"Emplyee ID : {EmployeeID}");
            Console.WriteLine($"Employee Name : {Name}");
            Console.WriteLine($"Employee Department : {Department}");
            Console.WriteLine($"Employee Salary : {Salary}");

        }
        public void IncreaseSalary(double amount)
        {
            Salary = Salary + amount;
            Console.WriteLine($"Salary increased by {amount:F2}, New salary amount is {Salary:F2}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(4869, "Umar", "DCS", 1000);
            emp.DisplayEmployeeDetails();
            emp.IncreaseSalary(300);
            Console.WriteLine("----**----");
            Console.WriteLine("After Update Information is :");
            emp.DisplayEmployeeDetails();
        }
    }
}
