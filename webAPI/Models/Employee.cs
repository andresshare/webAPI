using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webAPI.Models
{
    public class Employee
    {
        public long EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Deparment { get; set; }
        public string MailID { get; set; }
        public DateTime? DOJ { get; set; }
    }
}