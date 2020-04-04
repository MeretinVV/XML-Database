using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Search.Events
{
    public class DeleteEntryEventArgs : EventArgs
    {
        public string EmployeeID { get; internal set; }

        public DeleteEntryEventArgs(string employeeID)
        {
            EmployeeID = employeeID;
        }
    }
}
