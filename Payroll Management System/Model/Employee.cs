using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Payroll_Management_System.Model
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public char Type { get; set; }
    }
}