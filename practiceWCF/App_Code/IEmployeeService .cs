using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
namespace EmployeeServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.  
    [ServiceContract]
    public interface IEmployeeService
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        string AddEmployyeeRecord(Employee emp);

        [OperationContract]
        DataSet GetEmployeeRecords();

        [OperationContract]
        string DeleteRecords(Employee emp);

        [OperationContract]
        DataSet SearchEmployeeRecord(Employee emp);

        [OperationContract]
        string UpdateEmployeeContact(Employee emp);


    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.  
    [DataContract]
    public class Employee
    {

        string _empID = "";
        string _name = "";
        string _email = "";
        string _salary = "";
        string _department = "";

        [DataMember]
        public string EmpID
        {
            get { return _empID; }
            set { _empID = value; }
        }

        [DataMember]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        [DataMember]
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        [DataMember]
        public string Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        [DataMember]
        public string Department
        {
            get { return _department; }
            set { _department = value; }
        }
    }
}