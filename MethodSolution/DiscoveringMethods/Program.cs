// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n\tParallel Arrays\n");

const int PYHSICALSIZE = 25;
int logicalSize = 0;

//Create a program that will allow the user to enter up to 25 student names
//  and marks in a set of parallel arrays.
//Be able to display all current students and their marks.
//Calculate and display the mean average of the marks.
//Find the student with the highest mark.
//Find the student with the lowest mark.


//to shorten the example, good data will be assumed

string[] names = new string[PYHSICALSIZE];
int[] marks = new int[PYHSICALSIZE];
bool anotherStudent = false;
string inputValue = "";
int mark = 0;

try
{
    do
    {
        Console.Write("Enter the student name:\t");
        inputValue = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(inputValue))
        {
            anotherStudent = true;
            //the logicalSize is acting as the index to our arrays
            //the student names and marks are logically linked via the use of
            //  the same index value to indicate the data storage
            names[logicalSize] = inputValue;
            Console.Write($"Enter the mark for {inputValue}:\t");
            inputValue = Console.ReadLine();
            marks[logicalSize] = int.Parse(inputValue);
            logicalSize++; //don't forget to increment
            DisplayClass(names, marks, logicalSize);
        }
        else
        {
            anotherStudent = false;
        }

    } while (logicalSize < PYHSICALSIZE && anotherStudent);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
//call the method that will display my data
//this method returns nothing
//syntax  [variable = ] methodname([list of arguments]);
DisplayClass(names, marks, logicalSize);

//task of the method: display of the contents of an array collection
//syntax of the method 
//  access modifier returndatatype methodname([parameter list])
//  {  ... coding block ... }
//if the method does not return any value then the returndatatype is: void
//if the method does not return any value then there is NO return statement
//if the method does return a single value then the returndatatype is of the value
//if the method does return a value then the method MUST have a return statement

//FOR THIS COURSE AS A CLASS STANDARD ALL METHOD WILL BE STATIC !!!!!!!

static void DisplayClass(string[] myStrings, int[] numbers, int arraySize)
{ 
    Console.WriteLine("\nClass list with marks\n");
    for (int index = 0; index < arraySize; index++)
    {
        Console.WriteLine($"Student: {myStrings[index]} has a mark of {numbers[index]}");
    }
}

//calculate the class mean average
int sumOfMarks = 0;
double meanAverage = 0.0;
int classIndex = 0;
while (classIndex < logicalSize)
{
    sumOfMarks += marks[classIndex];
    classIndex++; //classIndex += 1;
}
meanAverage = (double)sumOfMarks / (double)logicalSize;
Console.WriteLine($"The mean average for our {logicalSize} students is " +
    $" {meanAverage.ToString("##0.0")}");

//find the student with the hightest mark
int highestMark = marks[0]; //assume the first mark is the highest
string topStudent = names[0];
int counter = 0; //counter is necessary due to the fact that we are
                 //  playing with parallel arrays

//the foreach loop is used for collections
//the foreach loop will
//  a) traverse your collection from the first entry to the last entry
//  b) you will use a "placeholder" identifier to represent the entry value
//  c) you DO NOT need to create or manage an index to your array
//syntax for the foreach loop:
//    foreach (datatype placeholder in collectionname)
//    { ....loop code .... }

//NOTE: many times you will see that the datatype can be of type: var
//      if "var" is used then the datatype is resolved at execution time
//      using a actual actual datatype, the resolution is at compile time
//      "var" takes its datatype from the collection datatype
//      Using "var" when coding, may affect the intelli-sense for the software

foreach (int theMark in marks)
{
    if (theMark > highestMark)
    {
        topStudent = names[counter];
        highestMark = theMark;
    }
    counter++; //only required due to the fact we are playing with parallel arrays
}
Console.WriteLine($"{topStudent} has the highest mark of {highestMark}");

//find the student with the lowest mark
int lowestMark = int.MaxValue; //MaxValue is the largest integer value possible
int lowestIndex = 0;

for (int index = 0; index < logicalSize; index++)
{
    if (marks[index] < lowestMark)
    {
        lowestIndex = index;
        lowestMark = marks[index];
    }
}
Console.WriteLine($"{names[lowestIndex]} has the lowest mark of {lowestMark}");