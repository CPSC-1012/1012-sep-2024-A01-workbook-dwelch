// See https://aka.ms/new-console-template for more information
using System.IO;

Console.WriteLine("\n\tIns and Outs of file processing\n");

//Name Don Welch
//Modified Oct 29 2024
//Create a program to demonstrate the ability to read and write to/from
//  a file. The file record will contain 2 pieces of data. Place the
//  data into parallel arrays.

//this program will use StreamReader/StreamWriter for its I/O technique
//benefits:
//  a) very large files, whole file does not need to be in memory all at
//          the same time
//  b) do not intend to read the entire file

#region Driver
//Create 2 arrays for student names and marks (physical size 25)
//Create counter for array logical size
//Declare filename as constant

//Need to know
//a) where is the file located on your machine
//b) what is the file name

//by default 
//  your program will expect the physical file to be in the same folder
//  as the .exe file when you compile

//you can use relative addressing to indicate a different location then
//  the default
//you can add several ../ folder increments to reposition the location
//  to find your physical file

//typical extensions of your text file can be
//  a) .txt
//  b) .csv (comma separate value, it can be handled as column in excel)

const string FILENAME = "../../../GoodData.txt";
const int PHYSICALSIZE = 25;
string[] students = new string[PHYSICALSIZE];
double[] marks = new double[PHYSICALSIZE];
int logicalSize = 0;

//Driver
//Call method to read the class list from file
logicalSize = ReadNamesandMarks(students, marks, FILENAME);
//Call method to display the class list
DisplayClassList(students, marks, logicalSize);
//Call method to add a student
logicalSize = AddStudentandMark(students, marks, logicalSize);
//Call method to display the class list
DisplayClassList(students, marks, logicalSize);
//Call method to write the class list to file
WriteNamesandMarks(students, marks, logicalSize, FILENAME);
#endregion

#region Methods
//Methods
//int ReadNamesandMarks(string[] studentNames, double[] studentMarks, string fileName)
static int ReadNamesandMarks(string[] studentNames, double[] studentMarks, string fileName)
{
    //the skeleton of the method is often referred to as a method stub
    //method reminder: parameters are "treated" as local variables

    //place a few comments within the method to explain what the method will do
    //Purpose: Read the course grades file and store the data to the arrays

    //steps:
    // a) Declare local variables: StreamReader, counter, input string
    // b) Test to see if the file exists
    //    1) no: display an appropriate message and exit method
    //    2) yes: read the file
    //            process each file record one at a time
    //            for each record, split data and store into arrays
    //            increment record count for each record read

    StreamReader streamReader = null;
    int recordsRead = 0; //act in the same fashion as the logicalSize
    string inputLine = "";

    //there are a couple of techniques to use to read a file
    //StreamReader (this course uses the StreamReader/StreamWriter technique)
    //  is useful if you have a very large file and your intention
    //      is that you may not be reading the entire file
    //      OR
    //      the file will not total fit in your machine
    //use the System.IO.File class
    //  is class have several methods created that allow for
    //      reading of files that are not extremely large
    //      AND your intent is to read the entire file

    //use the File class to check to see if the file actually exists
    if (File.Exists(fileName))
    {
        //read the file
        //as you read your file, if an error occurs you need to catch the error and handle it
        try
        {
            //setup the instance for "pipeline" to read your data from the file
            //this opens the file to be read
            streamReader = new StreamReader(fileName);

            //read the file record by record (loop)
            //when you reach the end of the file, the system will set a flag called EndOfStream
            //   this will indicate that you have reached the end of the file
            while(!streamReader.EndOfStream)
            {
                //read a line
                inputLine = streamReader.ReadLine();

                //next, we need to separate the values on the line into
                //  their appropriate arrays
                //to do this, we will use a string method call .Split('deliminator')
                //the deliminator can be any single character.
                //for a csv file (comma separate values) the deliminator is a comma ,
                //the Split() method will split the data on the line into separate values
                //  at the deliminator
                //the Split() method returns the values of the line to an string array
                string[] lineValues = inputLine.Split(',');

                //note: assuming the values in the file are valid
                studentNames[recordsRead] = lineValues[0];
                studentMarks[recordsRead] = double.Parse(lineValues[1]);

                //increment your number of records read
                recordsRead++;

            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"System Read error: {ex.Message}");
        }
        finally
        {
            //this is an optionally piece of code that can be used on your try/catch
            //normally
            //  you will execute all of the try successfully, exit the try/catch
            //or
            //  an error will be generated and you will process the catch, exit the try/catch

            //the finally will be execute WHETHER you exited the try/catch successful or having
            //      an error

            //in this code, we will manually close the file that is being read
            //attempt to close the file ONLY if you have a reader.
            if(streamReader != null)
            {
                streamReader.Close(); //manually close the existing "pipeline" to your file.
            }
        }
    }
    else
    {
        Console.WriteLine($"File does not exist. No records read.");
    }
    return recordsRead;
}
//void DisplayClassList(string[] studentNames, double[] studentMarks, int logicalSize)
static void DisplayClassList(string[] studentNames, double[] studentMarks, int logicalSize)
{
    Console.WriteLine($"\n\nThe current class size is {logicalSize} and is as follows:\n");
    Console.WriteLine("{0,-25} {1,6:##0.0}", "Name", "Mark");
    for(int i = 0; i <logicalSize;i++)
    {
        Console.WriteLine("{0,-25} {1,6:##0.0}", studentNames[i], studentMarks[i]);
    }
}
//int AddStudentandMark(string[] studentNames, double[] studentMarks, int logicalSize)
static int AddStudentandMark(string[] studentNames, double[] studentMarks, int logicalSize)
{
    //prompt the user for a student name and mark
    //validate the input
    //could loop until no more input
    //each student and mark would be added to the appropriate arrays
    //increment your logical size for each new student added to the class list

    studentNames[logicalSize] = "Iam Stew-Dent";
    studentMarks[logicalSize] = 66.6;
    logicalSize++;

    return logicalSize;
}
//void WriteNamesandMarks(string[] studentNames, double[] studentMarks, int logicalSize, string fileName)
static void WriteNamesandMarks(string[] studentNames, double[] studentMarks, int logicalSize, string fileName)
{
    StreamWriter streamWriter = null;
    string outputLine = "";
    try
    {
        //create an instance of the actual StreamWriter

        //if your file DOES NOT exist, it will be created and opened
        //if your file DOES exist, it will be opened

        //depending on the write options, action against your will vary
        // a)to OVERWRITE all existing lines use the option-> false
        // b)to APPEND to the existing lines use the option-> true
        streamWriter = new StreamWriter(fileName, false);

        //write the file
        //the program will create the output line and write it to the file
        //number of records is known (logicalSize)
        for (int i = 0; i < logicalSize; i++)
        {
            //build the output line
            outputLine = $"{studentNames[i]},{studentMarks[i]}";
            //write to the file
            streamWriter.WriteLine(outputLine);
        }

    }
    catch (Exception ex)
    {
        Console.WriteLine($"System write error: {ex.Message}");
    }
    finally
    {
        if (streamWriter != null)
        {
            streamWriter.Close(); //manually close the existing "pipeline" to your file.
        }
    }
}
#endregion
