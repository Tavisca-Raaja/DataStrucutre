using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
     class EmployeeDetails
    {
        private string EmployeeName;
        private string EmployeeId;
        private string Qualification;
        private string Age;
        private string ContactNumber;
       public  EmployeeDetails()
        {
            EmployeeName = "";
            EmployeeId = "";
            Qualification = "";
            Age = "";
            ContactNumber = "";
        }
        public string EName
        {
            get
            {
                return this.EmployeeName;
            }
            set
            {
                this.EmployeeName = value;
             
            }
        }
        public string EmpId
        {
            get
            {
                return this.EmployeeId;
            }
            set
            {
                this.EmployeeId = value;

            }
        }
    }
}
