//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lab4
//{
//    class Employee
//    {
//        public int employeeID { get; }
//        public string FullName { get; set; }
//        public double Salary { get; private set; }

//        public Employee(int ID, string name, double salary)
//        {
//            employeeID = ID;
//            FullName = name;
//            Salary = salary;
//        }

//        public void DisplayEmployeeInfo()
//        {
//            Console.WriteLine("ID: " + employeeID);
//            Console.WriteLine("Name: " + FullName);
//            Console.WriteLine("Salary: " + Salary);
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Employee employeea = new Employee(101, "John Doe", 50000);
//            Console.WriteLine("Employee ID: " + employeea.employeeID);
//            employeea.FullName = "John Snow";

//            //employee.Salary = 60000;
//            // Observations:
//            // Salary property is private which prevents external changes. Hence this actions result in an compile error.
//            Console.ReadLine();
//        }
//    }
//}
