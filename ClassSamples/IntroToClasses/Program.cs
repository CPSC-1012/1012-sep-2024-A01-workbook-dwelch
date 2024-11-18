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
myDog.SetAge(4.5);
DisplayMyPet(myDog);

static void DisplayMyPet(Dog myDog)
    
{
    //Dog instance contains the data value No.
    Console.WriteLine($"My dog is called {myDog.GetName()}");
    Console.WriteLine($"My dog is {myDog.GetAge()} years old.");
}
