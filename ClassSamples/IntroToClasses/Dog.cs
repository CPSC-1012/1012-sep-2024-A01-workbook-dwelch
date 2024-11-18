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
    }
}
