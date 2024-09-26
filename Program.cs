using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListIntro
{
    internal class Program
    {
        public static void PrintList(List<int> numbers)
        {
            foreach (int number in numbers)
            {
                Console.Write(number+",");
            }
            Console.WriteLine();

        }

        static void Main(string[] args)
        {
            
            List<int> numbers = new List<int>();
            numbers.Add(5);   // הוספת המספר 5 לרשימה
            numbers.Add(10);  // הוספת המספר 10 לרשימה
            PrintList(numbers); // הדפסת הרשימה
            numbers.AddRange(new int[] { 20, 25, 30 });
            PrintList(numbers); // הדפסת הרשימה



            Console.WriteLine("First: " + numbers[0]);  // הדפסת האיבר הראשון
            Console.WriteLine("How Many: " + numbers.Count );  // כמות האיברים ברשימה

            numbers.Remove(5);   // הסרת האיבר 5
            Console.WriteLine("10 exists " + numbers.Contains(10));  // בדיקה אם 10 קיים ברשימה

            numbers.Clear();     // מחיקת כל האיברים
            List<Employee> employees = new List<Employee>();

            // Adding employees to the list
            employees.Add(new Employee(1, "John Doe", 101, 5000.0));
            employees.AddRange(new List<Employee>
{
    new Employee(2, "Jane Smith", 102, 6000.0),
    new Employee(3, "Mark Johnson", 103, 5500.0)
});

            // Displaying the first employee
            Console.WriteLine("First employee: " + employees[0].GetFullName());

            // Finding an employee by Employee ID (without LINQ)
            Employee employee = null;
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].GetEmployeeID() == 1)
                {
                    employee = employees[i];
                    break;
                }
            }

            if (employee != null)
            {
                Console.WriteLine("Employee found: " + employee.GetFullName());
                employee.SetSalary(7500.0);  // Updating salary
            }

            // Removing the found employee (without LINQ)
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].GetEmployeeID() == 1)
                {
                    employees.RemoveAt(i);
                    Console.WriteLine("Employee removed from the list");
                    break;
                }
            }

            // Displaying the number of employees in the list
            Console.WriteLine("Number of employees in the list: " + employees.Count);

            // Clearing the list
            employees.Clear();
            Console.WriteLine("The list has been cleared.");



        }
    }
}
