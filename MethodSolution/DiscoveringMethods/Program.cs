// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n\tParallel Arrays Using Methods\n");

#region Driver Routine
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
        //this method passes no parameters but receives a valid from the method
        //  as the method completes.
        inputValue = GetStudentName();
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

//how to sort the arrays and keep the relationship between the two arrays
Array.Sort(names, marks, 0, logicalSize);


//call the method that will display my data
//this method returns nothing
//syntax  [returnvariablename = ] methodname([list of arguments]);
//syntax of the argument list
//  value [, value [, ...]]
//Rules: for your argument list
//  value is any valid C# value
//  the order of values MUST match the expectd order defined by the method
//  the value MUST be of the expected datatype of the parameter defined by the method
DisplayClass(names, marks, logicalSize);
CalculateAverage(logicalSize, marks);
HighestStudentMark(marks, names);
int lowestIndex = GetLowestMarkIndex(logicalSize, marks);
Console.WriteLine($"{names[lowestIndex]} has the lowest mark of {marks[lowestIndex]}");
#endregion


#region Methods
//task of the method: display of the contents of an array collection
//syntax of the method 
//  access modifier returndatatype methodname([parameter list])
//  {  ... coding block ... }
//syntax of the parameter list
//   datatype localvariablename [, datatype localvariablename [, ....]]
//
//all locally declared variables within the method exist ONLY as long as the
//      method is executing
//
//if the method does not return any value then the returndatatype is: void
//if the method does not return any value then there is NO return statement
//if the method does return a single value then the returndatatype is of the value
//if the method does return a value then the method MUST have a return statement

//FOR THIS COURSE AS A CLASS STANDARD ALL METHODS WILL BE STATIC !!!!!!!

//created a method called void DisplayClass(string[] myStrings, int[] numbers, int arraySize)
//this declares your contract for the method
//method header is the fully qualified method definition
//method signature is the methodname and list of parameters

static void DisplayClass(string[] myStrings, int[] numbers, int arraySize)
{
   
    //any variable that is required for this code must be declared within the method
    //any variable that is declared within the method exists ONLY as long as the
    //  method executes
    //consider any parameter variable as a locally declared variable
    Console.WriteLine("\nClass list with marks\n");
    for (int index = 0; index < arraySize; index++)
    {
        Console.WriteLine($"Student: {myStrings[index]} has a mark of {numbers[index]}");
    }

    //this method returns nothing (void), therefore there is NO return statement
}

static void CalculateAverage(int logicalSize, int[] marks)
{
    //calculate the class mean average
    //the logicalSize is a local variable and is DIFFERENT then the logicalSize in the driver
    //the mark is a local variable and is DIFFERENT the the marks in the driver
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
}

static string GetStudentName()
{
    Console.Write("Enter the student name:\t");
    string inputValue = Console.ReadLine();

    //since the return datatype is NOT void but an actual datatype, this method
    //  is required to have a return statement
    //syntax of the return statement:
    //     return valid C# value of the expected datatype
    return inputValue;
}

static void HighestStudentMark(int[] marks, string[] names)
{
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
}

static int GetLowestMarkIndex(int logicalSize, int[] marks)
{
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
    return lowestIndex;
}
#endregion