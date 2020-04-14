using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nhibernate.Demo.Exercise.Domain
{
    public class Address
    {
        public virtual long AddressId { get; set; }
        public virtual string City { get; set; }
    }
}