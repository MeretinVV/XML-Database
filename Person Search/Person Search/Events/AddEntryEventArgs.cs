using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Search.Events
{
    public class InsertEntryEventArgs : EventArgs
    {
        public string EmployeeID { get; internal set; }
        public string DepartmentID { get; internal set; }
        public string LastName { get; internal set; }
        public string Sex { get; internal set; }
        public string Salary { get; internal set; }
        public string HireDate { get; internal set; }
        public string ComissionPercent { get; internal set; }
        public string IncomeTax { get; internal set; }
        public string DaysWorked { get; internal set; }
        public string WorkDaysTotal { get; internal set; }
        public string MoneyCredited { get; internal set; }
        public string MoneyWithheld { get; internal set; }

        public InsertEntryEventArgs(string employeeID, string departmentID, string lastName, string sex, 
            string salary, string hireDate, string comissionPercent, string incomeTax, string daysWorked,
            string workDaysTotal, string moneyCredited, string moneyWithheld)
        {
            EmployeeID = employeeID;
            DepartmentID = departmentID;
            LastName = lastName;
            Sex = sex;
            Salary = salary;
            HireDate = hireDate;
            ComissionPercent = comissionPercent;
            IncomeTax = incomeTax;
            DaysWorked = daysWorked;
            WorkDaysTotal = workDaysTotal;
            MoneyCredited = moneyCredited;
            MoneyWithheld = moneyWithheld;
        }
    }
}
