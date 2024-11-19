// See https://aka.ms/new-console-template for more information
using Animals;


Console.WriteLine("\n\tHello, World of Classes\n!");

//the class standard for coding classes will be
//  each class defintion will be coding in a separate phyiscal file

Dog myDog = null;
Cat myCat = null;

//create an instance of the class definition Dog
//the instance is the object of the class
//you may have as many instances of a class as you wish, each
//  is unique, each holds its own values of the characteristics
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
    Console.WriteLine($"The dog belonging to {myDog.FullName} is called {myDog.GetName()}"); //using properties
    //Console.WriteLine($"My dog is {myDog.GetAge()} years old.");
    Console.WriteLine($"My dog is {myDog.Age} years old."); //this makes use of a property
                                                            //the system recognizes that the property is not
                                                            // part of an assignment operation, and therefore
                                                            //     knows to used the getter
}
