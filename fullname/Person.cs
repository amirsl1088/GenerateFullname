using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullname
{
   public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GetFullName(string firstname,string lastname)
        {
            return firstname + " " + lastname;
        }
    }
}
