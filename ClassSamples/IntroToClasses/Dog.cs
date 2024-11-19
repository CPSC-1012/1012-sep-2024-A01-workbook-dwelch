//these are existing namespaces within the C# version
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//when you create a class within a project, by default, the
//  namespace of your class is the project name

namespace Animals
{
    //the defintion of the class name is
    //a) access level
    //     private nothing outside of the class has access to items
    //                within the class
    //     internal access to the class is limited to programming
    //                  within the project
    //     public access to the class is open to an outside user
    //              of the class
    //b) the key word class
    //c) the programmer defintion name of the class
    public class Dog
    {
        //declare the characteristics of a Dog
        //each characteristic is a variable
        //a valid  characteristic has a valid C# datatype
        //NOTE: a class can have various datatyes

        //Data Members (aka; fields, variables, ...)
        //if you wish to encapsulate your data in a secure fashion
        //  your characteristic have an access type of private
        //if your characteristics is private then acces to that
        //  piece of data will be via a property or method (behaviour)
        //if you characteristic is public then any outside user
        //  of the class can access the data directly

        //DEPENDING on how the rest of your class is define, you
        //  may or maynot have a specific data member to a piece of data

        private string _Name;
        private double _Age;
        private string _OwnerFirstName;
        private string _OwnerLastName;
        private string _Breed;

        //Behavour (aka method)
        //mutator (aka setter)
        public void SetName(string name)
        {
            _Name = name;
        }
        public void SetAge(double age)
        {
            _Age = age;
        }
        //accessor (aka getter)
        public string GetName()
        {
            return _Name;
        }
        public double GetAge()
        {
            return _Age;
        }

        public string GetFullName()
        {
            return $"{_OwnerLastName}, {_OwnerFirstName}";
        }

        public void CelebrateBrithday()
        {
            _Age = Math.Floor(_Age++);
        }

        //Each class has a given set of methods
        //ONe such method is called ToString()
        //this method can of overridden with your own version
        public override string ToString()
        {
            return $"{_Name},{_Age},{_OwnerFirstName},{_OwnerLastName},{_Breed}";
        }

        //Properties

        //consider this a special type of method
        //a property is an interface to private data within your class definition
        //a property is associated with a SINGLE piece of data
        //a property is public
        //a property MUST have an accessor (getter)
        //  the getter returns a piece of data
        //  the getter is public
        //a property MAY have a mutator (setter)
        //  the setter assigns a value to your privage data member
        //  a setter may be either public (default) or private
        //  if the setter is private, it can be used from within the class
        //      it CANNOT beused by an outsider user
        //  a property without a setter is referred to as "readonly"
        //PROPERTIES DO NOT HAVE A PARAMETER LIST!!!!!!! NOT EVEN THE ( )!!!!!!
        //properties use a special key word to refer to the incoming data value
        //      that key word is -> value

        //there are two ways to code a property
        //  a) fully-implemented property
        //  b) auto-implemented property

        //Don's Rule: wherever possible within the class coding, use the property
        //              to acces your data.

        //Fully-implemented property
        //a fully-implemented property will have an associated data member
        //data is transfer via the property into/out of the data member
        //the data is NOT store in the property
        //a property can have additional logic within its coding
        //  this logic is using validation of some type
        public string OwnerFirstName
        {
            //accessor
            get { return _OwnerFirstName; }

            //mutator
            set 
            { 
                if(string.IsNullOrWhiteSpace(value))
                {
                    //cast an error message
                    //within a class, casting error messages is done using Exceptions
                    //if this exception is throw then the processing in the class
                    //  is terminated and the system returns to where the property
                    //  was being used.
                    throw new Exception("You are missing the owner first name.");
                }
                _OwnerFirstName = value; 
            }
        }
        public double Age
        {
            //accessor
            get { return _Age; }

            //mutator
             set { _Age = value; }

        }
        public string OwnerLastName
        {
            //accessor
            get { return _OwnerLastName; }

            //mutator
            set { _OwnerLastName = value; }
        }

        //to replace the method GetFullName() you could create a property
        //  that returns the full name
        //this property is read-only as it does not have a setter
        //a property has access to all data within the class
        //NOTE: there is no data member associated with this property, it uses other data

        public string FullName
        {
            //this example is demonstrating that actions within the class can use
            //  BOTH/EITHER the data member OR the property
           
            get { return $"{_OwnerLastName}, {OwnerFirstName}"; }
        }

        public string Breed
        {
            //accessor
            get { return _Breed; }

            //mutator
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    //cast an error message
                    //within a class, casting error messages is done using Exceptions
                    //if this exception is throw then the processing in the class
                    //  is terminated and the system returns to where the property
                    //  was being used.
                    throw new Exception("You are missing the breed.");
                }
                _Breed = value;
            }
        }
    }
}
