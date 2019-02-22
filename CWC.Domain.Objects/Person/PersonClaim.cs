using System;
using System.Collections.Generic;
using System.Text;

namespace CWC.Domain.Objects.Person
{
   
class PersonClaim
    {
        public string id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string dateJoined { get; set; }
        public bool isActive { get; set; }


    }
}
