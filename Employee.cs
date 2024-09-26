using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListIntro
{
    public class Employee
    {
        private int employeeID;
        private string fullName;
        private int departmentCode;
        private double salary;

        // גט וסט קלאסיים עבור employeeID
        public int GetEmployeeID()
        {
            return employeeID;
        }

        public void SetEmployeeID(int value)
        {
            employeeID = value;
        }

        // גט וסט קלאסיים עבור fullName
        public string GetFullName()
        {
            return fullName;
        }

        public void SetFullName(string value)
        {
            fullName = value;
        }

        // גט וסט קלאסיים עבור departmentCode
        public int GetDepartmentCode()
        {
            return departmentCode;
        }

        public void SetDepartmentCode(int value)
        {
            departmentCode = value;
        }

     
        public double GetSalary()
        {
            return salary;
        }

        public void SetSalary(double value)
        {
            salary = value;
        }

        // בנאי לקבלת ערכים בעת יצירת אובייקט
        public Employee(int employeeID, string fullName, int departmentCode, double salary)
        {
            this.employeeID = employeeID;
            this.fullName = fullName;
            this.departmentCode = departmentCode;
            this.salary = salary;
        }

        // פונקציה להצגת פרטי העובד
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"מספר עובד: {employeeID}, שם מלא: {fullName}, קוד מחלקה: {departmentCode}, שכר: {salary}");
        }
    }


}
