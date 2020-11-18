using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmloyeePractical
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmployeeService.svc or EmployeeService.svc.cs at the Solution Explorer and start debugging.
    public class EmployeeService : IEmployeeService
    {
        EmployeeDataContext data = new EmployeeDataContext();
        public bool AddDepartment(Department newDpm)
        {
            try
            {
                data.Departments.InsertOnSubmit(newDpm);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool AddEmployee(Employee newEmp)
        {
            try
            {
                data.Employees.InsertOnSubmit(newEmp);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool DeleteDepartment(string id)
        {
            try
            {
                var department = data.Departments.Where(b => b.DepartmentID == int.Parse(id)).FirstOrDefault();
                data.Departments.DeleteOnSubmit(department);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool DeleteEmployee(string id)
        {
            try
            {
                var employee = data.Employees.Where(b => b.EmployeeID == int.Parse(id)).FirstOrDefault();
                data.Employees.DeleteOnSubmit(employee);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool EditDepartment(string id, Department newDpm)
        {
            try
            {
                var department = data.Departments.Where(b => b.DepartmentID == int.Parse(id)).FirstOrDefault();
                data.Departments.DeleteOnSubmit(department);
                data.Departments.InsertOnSubmit(newDpm);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool EditEmployee(string id, Employee employee)
        {
            try
            {
                var employees = data.Employees.Where(b => b.EmployeeID == int.Parse(id)).FirstOrDefault();
                data.Employees.DeleteOnSubmit(employees);
                data.Employees.InsertOnSubmit(employee);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public List<Department> GetDepartments()
        {
            try
            {
                var departments = (from department in data.Departments select department).ToList();
                return departments;
            }
            catch { return null; }
        }

        public List<Employee> GetEmployees()
        {
            try
            {
                var employees = (from employee in data.Employees select employee).ToList();
                return employees;
            }
            catch { return null; }
        }
    }
}
