using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeClassess
{
    public class Owner
    {
        //auto implemented property
        //  it has NO additional logic within the property
        //  Simply hold a data value
        //  has NO associated private data member
        //  the system manages the internal saving and access
        //      to the data value
        //  access to the data value is ONLY via the property

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }

        public Owner()
        {
            //this default constructor is required BECAUSE the Program.cs
            //  driver is demonstrating object initialization
            //Object initialization REQIUIRES the class defintion to have
            //  a default constructor
        }

        public Owner(string firstname, string lastname, string phone)
        {
            //if you are using auto-implmented properties
            //  AND still need to do some validation THEN the
            //  validation needs to be coded elsewher in your class
            if (string.IsNullOrWhiteSpace(firstname))
            {
                throw new Exception("Missing value for first name");
            }

            FirstName = firstname;
            LastName = lastname;
            Phone = phone;
        }

        public override string ToString()
        {
            //Notice: you MUST use the property if you wish to touch
            //  the data value of the auto-implemented property
            return $"{FirstName},{LastName},{Phone}";
        }

        public string FullName
        {
            //this example is demonstrating that actions within this class MUST use
            //   the property

            get { return $"{LastName}, {FirstName}"; }
        }
    }
}
