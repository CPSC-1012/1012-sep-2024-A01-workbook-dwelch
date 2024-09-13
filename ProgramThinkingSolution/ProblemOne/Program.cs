// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System.Diagnostics.Metrics;

Console.WriteLine("Hello Don, Welcome to the Wonderful World C#!");

//Detailed Steps
//declare the program storage
//DECLARE conversionRate as Float
//DECLARE audienceSize as Integer
//DELCARE numberOfConversions as Float
//input
//PROMPT: Enter the conversion rate: 
//SET conversionRate(read)
//PROMPT: Enter the audience size: (read audienceSize)
//process
//CALCULATE  numberOfConversions = conversionRate * audienceSize
//output
//PRINT the numberOfConversions (round to nears whole number)

//camelCase: the first letter of the first word is lower case, the first letter
//              of remain words is upper case
//PacalCase (TitleCase): the first letter of each word is upper case

//variables have defaults when they are declared
//numerics: the value is 0
//strings: the value is null (null is the absence of a value)
//bool: the value is false

int audienceSize = 0;
double conversionRate, numberOfConversions = 0;
string inputValue = ""; // "" is a real physical piece of data; it is NOT the absence of data

//console I/O uses the Console class with the appropriate method
//ALL input enters your program as a string

//write the supplied literal string to the console AND remain on that
//  physical line
Console.Write("Enter the conversion rate:"); //prompt
//read the line entered into the console by the user until the enter key
//ALL input is consider a string WHEN read
inputValue = Console.ReadLine();

//YOU MAY NEED to convert the input to a different datatype such as a numeric
//this convertion is referred to as Parsing
//datatypes have a method that will do the conversion, if possible, for you
//typical syntax  datatype.Parse(string value)
conversionRate = double.Parse(inputValue);

//write the supplied literal string to the console AND move to the next
//  physical line
Console.WriteLine("Enter the audience size:"); //prompt
inputValue = Console.ReadLine();
audienceSize = int.Parse(inputValue);

numberOfConversions = conversionRate * audienceSize;

//your output expression can include variables
//string concentation
Console.WriteLine("The estimated number of converted individauls is " + numberOfConversions);
//string interpolation
Console.WriteLine($"The estimated number of converted individauls is {numberOfConversions}");