using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeConsumer.Models
{
    public class ServicesClient
    {
        EmployeeServices.EmployeeServiceClient client = new EmployeeServices.EmployeeServiceClient();
        public List<Department> getAllDepartment()
        {
            var list = client.GetDepartments().ToList();
            var rt = new List<Department>();
            list.ForEach(b => rt.Add(new Department()
            {
                DepartmentID = b.DepartmentID,
                DepartmentName = b.DepartmentName,
            }
            ));
            return rt;
        }
        public List<Employee> GetEmployees()
        {
            var list = client.GetEmployees().ToList();
            var rt = new List<Employee>();
            list.ForEach(b => rt.Add(new Employee()
            {
                EmployeeID = b.EmployeeID,
                EmployeeName = b.EmployeeName,
                salary = (int)b.Salary,
                DepartmentID = b.Department.DepartmentID,
            }
            ));
            return rt;
        }
        public bool AddDepartment(Department newDpm)
        {
            var department = new EmployeeServices.Department()
            {
                DepartmentID = newDpm.DepartmentID,
                DepartmentName = newDpm.DepartmentName,
              
            };
            return client.AddDepartment(department);
        }
        public bool AddEmployee(Employee newEmp)
        {
            var employee = new EmployeeServices.Employee()
            {
                EmployeeID = newEmp.EmployeeID,
                EmployeeName = newEmp.EmployeeName,
                Salary = newEmp.salary,
                DepartmentID = newEmp.Department.DepartmentID,

            };
            return client.AddEmployee(employee);
        }

    }
}