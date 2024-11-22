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

        //methods that do "stuff" against the data contained within the class
        //if the data is within the instance ALREADY then you DO NOT need to
        //  pass the data in with the method
        public void CelebrateBrithday()
        {
            _Age = Math.Floor(++_Age); // ++_Age: current age (4.5) + 1 -> 5.5 ->.floor(5.5) -> 5
        }                              // _Age++: current age (4.5) -> .floor(4.5) -> 4 -> 4.5 + 1 -> 5.5

        //overloaded method
        //overloaded methods are methods with the same method name BUT a
        //  different list of parameters
        public void CelebrateBrithday(double newAge)
        {
            if (newAge < 0)
            {
                throw new Exception("Age cannot be negative.");
            }
            Age = newAge;
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

        public string Name
        {
            //accessor
            get { return _Name; }

            //mutator
            set { _Name = value; }
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
        //Constructors

        //  these are used during the creation of an instance (occurance) of your
        //    class during your program execution

        //a class DOES NOT need a constructor physically code for it
        //if a class DOES NOT have a physically coded constructor method then
        //      the system will create the instance of your class
        //      using the system default values for your field datatype

        //HOWEVER!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //IF YOU CODE A CONSTRUCTOR PHYSCIALLY FOR YOUR CLASS, YOU ARE TOTALLY
        //      RESPONSIBLE FOR ANY AND ALL CONSTRUCTORS OF THE CLASS
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

        //how many constructors can a class have? Many

        //the purpose of the constructor is to ensure that the user of the class
        //  gets an expected usable valid instance of the class

        //there is generally two types of constructors coded for a class
        //you DO NOT need to code both!!!

        //syntax for a general constructor
        //   public className( [list of parameters] ) { coding block }

        //access: public
        //NO RETURN DATATYPE
        //name: is your class name
        //parameters: are optional
        //coding block: is C# code

        //Default constructor
        //this constructor will not have any parameters
        //the assumption is the data will have either
        //  a) the system datatype defaults
        //  b) any assigned literal values to ensure property validation is meet

        public Dog()
        {
            //IF there is no code in your default constructor assigning
            //  values to your data members, the data members will be set
            //  to their system defaults

            //the default constructor is often compared to the "system" constructor

            //HOWEVER

            //SINCE our properties have business rules (validation)
            //  our "default" constructor should ensure that data members within
            //  our class instance passes any validation

            //Consideration!!!!
            //does the property have any validation that would be a violation
            //  by just using the system datatype defaults?

            //in this example: OwnerFirstName and Breed cannot be null, empty or blank characters
            //thus, a literal value will be assigned that would pass the validation

            OwnerFirstName = "Unknown";
            Breed = "Unknown";

            //optionally
            //if you wished, you could assign values to your other data members
            //  even though they have acceptable default values

            Name = "unknown";
            OwnerLastName = "Unknown";

            //what about Age, 0 is a valid value
            Age = 0; //you can be explicive about your values
        }

        // Greedy Constructor
        //this constructor will receive a set of values for the data within the class
        //the parameters list is a complete list of values to cover all data members
        //  within the class
        //the constructor will assign the incoming values to the appropriate
        //  data members.
        //BEST PRACTICE: ASSIGN THE INCOMING VALUES TO THE DATA MEMBERS VIA THEIR PROPERTY
        //Why: the data will be validated 

        public Dog(string name, double age, string ownerfirstname,
                        string ownerlastname, string breed)
        {
            //it is possible to include validation for your incoming data within
            //  the greed constructor 
            //you might do this IF your properties do NOT contain validation
            //                  IF you have additional validation that is not within the property
            //                  IF your setter is private (not part of this course)
            //REMEMBER that once the instance is created using the constructor ANY alternations
            //  to your data via properties or methods, should, contain validation
            //Question? Why have the same code in multiple places
            //Solution:
            //  a) create a method that could be called from anywhere in the class defintion
            //      (Modular approach)
            //  b) if you use the practice of accessing your data via the properties
            //      within the class definition, then the validation could be placed
            //      in one location: properties. (Don's Rule)

            //in this demo, Age does not have any validation
            //the Age validation can be done in this construction AND any method using Age
            //  OR
            //place the validation within the Age properties and always, wherever possible,
            //  use the property to set or access the data value

            if (Age < 0)
            {
                throw new Exception("Age cannot be negative");
            }
            Name = name;
            Age = age;
            OwnerFirstName = ownerfirstname;
            OwnerLastName = ownerlastname;
            Breed = breed;
        }
    }
}


