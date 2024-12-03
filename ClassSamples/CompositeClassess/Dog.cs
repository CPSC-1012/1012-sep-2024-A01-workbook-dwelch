//these are existing namespaces within the C# version
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//when you create a class within a project, by default, the
//  namespace of your class is the project name

namespace CompositeClassess
{
    
    public class Dog
    {
        private string _Name;
        private double _Age;
        private string _Breed;

        //this class needs to make use of the owner information
        //the dog could exist without an owner
        //since this class with use another class but not as inheritance
        //  BUT as a Composite class (.... has a ....)
        //SINCE the Owner class SHOULD be ensuring its own validity, Dog
        //  should only have to hang onto the data.
        //  THEREFORE the owner could be coded as an auto-implemented property
        public Owner DogOwner { get; set; }

        //this is a collection of visits to the kennel
        //each visit is represented by the class Stay
        //one can the declaration statement of the property
        //  assign an initial instance to the List
        //  AND this list will be empty BUT it will list
        //without the assignment the List<T> is null
        public List<Stay> Visits { get; set; } = new List<Stay>();

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

      
        public void CelebrateBrithday()
        {
            _Age = Math.Floor(++_Age); // ++_Age: current age (4.5) + 1 -> 5.5 ->.floor(5.5) -> 5
        }                              // _Age++: current age (4.5) -> .floor(4.5) -> 4 -> 4.5 + 1 -> 5.5

        public void CelebrateBrithday(double newAge)
        {
            if (newAge < 0)
            {
                throw new Exception("Age cannot be negative.");
            }
            Age = newAge;
        }
   
        public override string ToString()
        {
            return $"{_Name},{_Age},{_Breed},{DogOwner.ToString()}";
        }

        public double Age
        {
            //accessor
            get { return _Age; }

            //mutator
             set { _Age = value; }

        }
    
        public string Name
        {
            //accessor
            get { return _Name; }

            //mutator
            set { _Name = value; }
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
                   
                    throw new Exception("You are missing the breed.");
                }
                _Breed = value;
            }
        }

        public Dog()
        {
         
            Breed = "Unknown";
            Name = "unknown";
            //what about Age, 0 is a valid value
            Age = 0; //you can be explicive about your values
            DogOwner = null; //you can be explicive about your values
            Visits = new List<Stay>(); //can possible assign empty instance of
                                       // List BUT it will NOT be null 
        }
        public Dog(string name, double age, string breed, Owner owner)
        {
            if (Age < 0)
            {
                throw new Exception("Age cannot be negative");
            }
            Name = name;
            Age = age;
            Breed = breed;
            DogOwner = owner;
        }

        public Dog(string name, double age, string breed,
                        string firstname, string lastname, string phone)
        {
            if (Age < 0)
            {
                throw new Exception("Age cannot be negative");
            }
            Name = name;
            Age = age;
            Breed = breed;
            DogOwner = new Owner(firstname, lastname, phone);
        }
    }
}


