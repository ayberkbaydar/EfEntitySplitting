using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntitySplittingDemoCodeFirst
{
    public class Employee
    {
        //Employees
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }


        //EmployeeContactDetails
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string LandLine { get; set; }

    }
}