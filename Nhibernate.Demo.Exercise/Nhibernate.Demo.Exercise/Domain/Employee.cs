using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nhibernate.Demo.Exercise.Domain
{
    public class Employee
    {
        public virtual long EmployeeId { get; set; }
        public virtual string EmployeeName { get; set; } 
        //public virtual Address Address { get; set; }
        public virtual long AddressId { get; set; }
    }
}