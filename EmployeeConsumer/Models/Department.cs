using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeConsumer.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}