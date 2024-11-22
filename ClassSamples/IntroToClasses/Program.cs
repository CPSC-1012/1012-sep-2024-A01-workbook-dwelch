// See https://aka.ms/new-console-template for more information
using Animals;


Console.WriteLine("\n\tHello, World of Classes\n!");

//the class standard for coding classes will be
//  each class defintion will be coding in a separate phyiscal file

Dog myDog = null; //objects are reference variables
Cat myCat = null;

//create an instance of the class definition Dog
//the instance is the object of the class
//you may have as many instances of a class as you wish, each
//  is unique, each holds its own values of the characteristics

//if your class definition does NOT have a constructor code within it
//  the call to create your instance is typically referred to as the : system constructor
myDog = new Dog(); 

//to access an item within a class you will use the dot (.) operator
//to use something within a other class the "something" needs an
//   access level of public or internal
myDog.SetName("No");
//myDog.SetAge(4.5); //this is a behaviour (method)
myDog.Age = 4.5; //this makes use of a property, 
                 //a property can be used as "if" it were a variable
                 //the system recognizes that the property is on the left
                 //     side of an assignment operation, and therefore
                 //     knows to used the setter

//demonstrate using a property in Dog that contains validation of the
//  data which will throw and exception

try
{
    
    myDog.OwnerFirstName = "Lowand";
    myDog.OwnerLastName = "Behold";
    myDog.Breed = "BloodHound";
    Console.WriteLine("\n\nDog created with default constructor\n");
    DisplayMyPet(myDog);

    Console.WriteLine("\n\nDog created with greedy constructor\n");

    //the constructor Dog(...) is used with the new command to tell the system
    //  what class instance to create and return to the caller.
    //NOTE: THE CONSTRUCTION CAN ONLY!!!!!! BE USED WITH THE new command
    myDog = new Dog("Boo", 13.4, "Charity", "Kase", "Mixed");
    DisplayMyPet(myDog);


}
catch(Exception ex)
{
    
    Console.WriteLine($"Class data error: {ex.Message}");
}


static void DisplayMyPet(Dog myDog)
    
{
    //Dog instance contains the data value No.
    //Console.WriteLine($"The dog belonging to {myDog.GetFullName()} is called {myDog.GetName()}"); //using methods
    Console.WriteLine($"The dog belonging to {myDog.FullName} is a {myDog.Breed} called {myDog.GetName()}"); //using properties
    //Console.WriteLine($"My dog is {myDog.GetAge()} years old.");
    Console.WriteLine($"My dog is {myDog.Age} years old."); //this makes use of a property
                                                            //the system recognizes that the property is not
                                                            // part of an assignment operation, and therefore
                                                            //     knows to used the getter
}
