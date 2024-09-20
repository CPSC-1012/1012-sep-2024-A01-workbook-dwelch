// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n\tPythagorean Theorem calculated using Math class!\n");

//a constant is a data storage item that has a programmer defined name
//                                       has a datatype
//                                       has an assigned value
//a constant, unlike a variable, CANNOT be altered
//a constant can be used in your code just like a variable
const double POWER_OF_TWO = 2.0;

double height, baseLength, hypotenuse;
string inputValue;
double measurementsSquared;

Console.Write("Enter your height:\t");
inputValue = Console.ReadLine();
height = double.Parse(inputValue);

Console.Write("Enter your base length:\t");
inputValue = Console.ReadLine();
baseLength = double.Parse(inputValue);

//rules of math
//items within (...) are done first
//* and / left to right
//+ and - left to right

//measurementsSquared = height * height;
//measurementsSquared = measurementsSquared + Math.Pow(baseLength, POWER_OF_TWO);
//hypotenuse = Math.Sqrt(measurementsSquared);

//measurementsSquared = height * height;
//measurementsSquared += Math.Pow(baseLength, POWER_OF_TWO);
//hypotenuse = Math.Sqrt(measurementsSquared);

//Refactoring
hypotenuse = Math.Sqrt((height * height) + (Math.Pow(baseLength, POWER_OF_TWO)));


Console.WriteLine($"\nThe hypotenuse of height: {height} and base {baseLength} is: {hypotenuse.ToString("F2")}");
