// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n\tWelcome to the Collective\n\n");

//single variable
//holds a single value
//it can be altered
//syntax: datatype name;
int grade = 78;
//grade = 78;

//a Collection
//C# supports various kinds of collections
//we will concentration at this time on Arrays
//an array represents a number of values of the same datatype
//referencing a particular value within the collection can be done using an "index"
//arrays are fixed size collections
//arrays hold a single datatype of values
//you must specify the maximum size of your array before you can use it
//if you try to reference an item via the index and the index is < 0 or greater then the max size, your
//  code will abort with an expection
//each value in the array can be referred to as the array element.
//syntax:  datatype [] arrayname [= new datatype[max-size]];

//Create an array of grades for a class of size 33
//We will fill the array with a random set of grades between 0 and 100.

//you might wish to create a constant of the array max size
const int PHYSICALSIZE = 33;

//DECLARATION
int[] grades = new int[PHYSICALSIZE]; //ask the system to allocate storage for the 33 integer values

Random rnd = new Random(); //ask the system to create an instance of the Random class (random generator)

for(int index = 0; index < PHYSICALSIZE; index++)
{
    grades[index] = rnd.Next(0, 101); // .Next(120, 201) / 100.0
}

for(int index =0; index < PHYSICALSIZE; index++)
{
    Console.WriteLine($"The grade at index {index} is {grades[index]}");
}