using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EmloyeePractical
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmployeeService" in both code and config file together.
    [ServiceContract]
    public interface IEmployeeService
    {
        //Employee CRUD
        [OperationContract]
        [WebInvoke(Method = "GET",
          ResponseFormat = WebMessageFormat.Json,
          RequestFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Bare,
          UriTemplate = "api/v1/GetEmployeeList"
        )]
        List<Employee> GetEmployees();
        [OperationContract]
        [WebInvoke(Method = "POST",
           ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "api/v1/CreateLocation"
         )] // định nghĩa đường link trả về
        bool AddEmployee(Employee newEmp);
        [OperationContract]
        [WebInvoke(Method = "PUT",
          ResponseFormat = WebMessageFormat.Json,
          RequestFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Bare,
          UriTemplate = "api/v1/EditEmployee/{id}"
        )]
        bool EditEmployee(string id, Employee employee);
        [OperationContract]
        [WebInvoke(Method = "POST",
          ResponseFormat = WebMessageFormat.Json,
          RequestFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Bare,
          UriTemplate = "api/v1/DeleteEmployee/{id}"
        )]
        bool DeleteEmployee(string id);
        //Department CRUD
        [OperationContract]
        [WebInvoke(Method = "GET",
         ResponseFormat = WebMessageFormat.Json,
         RequestFormat = WebMessageFormat.Json,
         BodyStyle = WebMessageBodyStyle.Bare,
         UriTemplate = "api/v1/GetDepartmentList"
       )]
        List<Department> GetDepartments();
        [OperationContract]
        [WebInvoke(Method = "POST",
           ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "api/v1/CreateDepartment"
         )] // định nghĩa đường link trả về
        bool AddDepartment(Department newDpm);
        [OperationContract]
        [WebInvoke(Method = "PUT",
          ResponseFormat = WebMessageFormat.Json,
          RequestFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Bare,
          UriTemplate = "api/v1/EditDepartment/{id}"
        )]
        bool EditDepartment(string id, Department newDpm);
        [OperationContract]
        [WebInvoke(Method = "POST",
          ResponseFormat = WebMessageFormat.Json,
          RequestFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Bare,
          UriTemplate = "api/v1/DeleteDepartment/{id}"
        )]
        bool DeleteDepartment(string id);
    }
}
