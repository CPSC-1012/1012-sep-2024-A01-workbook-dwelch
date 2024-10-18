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

//traverse (walk through the collection) the array filling in each element with a
//  random value between 0 and 100 inclusive
//since arrays are of a particular size and referencing an array element
//  is via a numeric index, the preferred iteration structure would be the for loop
//the index of this array is 0 through 32 (the natural count is 1 to 33)
for (int index = 0; index < PHYSICALSIZE; index++)
{
    grades[index] = rnd.Next(0, 101); // .Next(120, 201) / 100.0
                                      // .NextDouble() gives a value between 0.0 and 1.0
                                      //     assume 0.12 was return -> 0.12 * 100.0
}

//traverse (walk through the array) the array display each array element
//Console.WriteLine("Original array load\n");
//for (int index =0; index < PHYSICALSIZE; index++)
//{
//    Console.WriteLine($"The grade at index {index} is the {index + 1}th element and is {grades[index]}");
//}

//declaring the array size by supplying a set of values on the declaring statement
//when you supply a set of values, the system automatically set the size of your array
//  to the number of values
//using this technique not only gives the array its size BUT ALSO its initial element values
//the following creates an array of 7 elements which element holds a string
string[] dayOfWeek = new string[] {"Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

//What if you did not create a constant with a value of 7
//how does one know the size of their array?
//arrays have properties that the coder can access
//the array size property is: .Length
for (int index = 0; index < dayOfWeek.Length; index++)
{
   // Console.WriteLine($"The week of day at index {index} is the {index + 1}th element and is {dayOfWeek[index]}");
}

//array have built-in functionality that you as a coder can use
//How about sorting the array?
//you could use the array method called Sort

//default ascending Sort on the grades
Array.Sort(grades);
//Console.WriteLine("\nDefault ascending sorted array\n");
for (int index = 0; index < PHYSICALSIZE; index++)
{
    Console.WriteLine($"The grade at index {index} is the {index + 1}th element and is {grades[index]}");
}

//Are the other ways to sort, such as descending
//there are other ways to use Sort by a supplying more details of how to sort
//sort ascending
//Array.Sort(thearray, (x,y) => predicate)
//thearray is your collection
//(x,y) represent any 2 values in your collection
// => (lamda symbol - i suggest your read as : "do the following")
//predicate - this is the action for the sort

//Array.Sort(grades, (x, y) => x.CompareTo(y)); //compare x to y in an ascending sort
//for (int index = 0; index < PHYSICALSIZE; index++)
//{
//    Console.WriteLine($"The grade at index {index} is the {index + 1}th element and is {grades[index]}");
//}

//sort descending
//Array.Sort(grades, (x, y) => y.CompareTo(x)); //compare y to x in an descending sort
//for (int index = 0; index < PHYSICALSIZE; index++)
//{
//   // Console.WriteLine($"The grade at index {index} is the {index + 1}th element and is {grades[index]}");
//}

//What about resetting the array (reset to 0)
//manually do it
//Console.WriteLine("\nResetting the array to default values\n");
//for (int index = 0; index < PHYSICALSIZE; index++)
//{
//    grades[index] = 0;
//}

//Array.Clear(grades);
//for (int index = 0; index < PHYSICALSIZE; index++)
//{
//     Console.WriteLine($"The grade at index {index} is the {index + 1}th element and is {grades[index]}");
//}

//locating items within yur array collection
Console.WriteLine("\nLocating values within an array\n");

//there are several techniques for locating an item in your collection
// a) traverse the whole collection: counter loop -> for
// b) traverse until the value is located (quick exit): sentinal loop -> while
// c) using built-in methods

//obtain the search arg value from the user
Console.Write("\n\tEnter the value to locate:\t");
int searchArg = int.Parse(Console.ReadLine()); //assuming valid data

//option a
bool found = false; //assume that the data is NOT in the collection
int foundIndex = -1; //invalid index, index start at 0, this will hold the location of the value in the array
for (int index = 0; index < grades.Length; index++) //you could have used PHYSICALSIZE
{
    if(searchArg == grades[index])
    {
        found = true;
        foundIndex = index;
        //can one do a quick exit??
        //yes
        index = grades.Length; //set your counter to its max value
    }
}
if (found)
{
    Console.WriteLine($"\nYour serach for {searchArg} was successful. It was found at element {foundIndex + 1}.");
}
else
{
    Console.WriteLine($"\nYour serach for {searchArg} was unsuccessful. It was not found.");
}

//option b
found = false;
foundIndex = -1;
int quickIndex = 0; //using the while requires the coder to manage the iteration
while (!found && quickIndex < PHYSICALSIZE)  //could have used grades.Length
{
    if (searchArg == grades[quickIndex])
    {
        found = true;
        foundIndex = quickIndex;
    }
    quickIndex++;
}
Console.WriteLine($"\n\tExiting the loop at index {quickIndex--}\n"); //proof of quick exit
if (found)
{
    Console.WriteLine($"\nYour serach for {searchArg} was successful. It was found at element {foundIndex + 1}.");
}
else
{
    Console.WriteLine($"\nYour serach for {searchArg} was unsuccessful. It was not found.");
}

//option c
//Array has a method that will do the search for you
//Array FindIndex(arrayname, predicate)
//predicate syntax: x => condition
// where x represents any element in the array
// => lamda symbol (read as: do the following)
//predicate which is the condition to execute for the current element of the array
//what is returned
//  not found returns -1
//  found returns the index of the FIRST element satisfying the predicate

foundIndex = -1;
foundIndex = Array.FindIndex(grades, x => x == searchArg);
if (foundIndex >= 0)
{
    Console.WriteLine($"\nYour serach for {searchArg} was successful. It was found at element {foundIndex + 1}.");
}
else
{
    Console.WriteLine($"\nYour serach for {searchArg} was unsuccessful. It was not found.");
}