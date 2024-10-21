// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n\tParallel Arrays\n");

const int PYHSICALSIZE = 25;
int logicalSize = 0;

//Create a program that will allow the user to enter up to 25 names
//  and markds in a set of parallel arrays.
//Calculate and display the mean average of the marks.
//Find the student with the highest mark.
//Find the student with the lowest mark.
//Be able to display all current students and their marks.

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
            //the names and marks are logically linked via the use of
            //  the same value to indicate the data storage
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
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine("\nClass list with marks\n");
for(int index = 0; index < logicalSize; index++)
{
    Console.WriteLine($"Student: {names[index]} has a mark of {marks[index]}");
}


