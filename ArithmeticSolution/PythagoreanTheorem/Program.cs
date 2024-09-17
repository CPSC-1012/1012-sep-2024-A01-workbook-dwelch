// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n\tPythagorean Theorem calculated using Math class!\n");

double height, baseLength, hypotenuse;
string inputValue;

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

hypotenuse = Math.Sqrt(height * height + Math.Pow(baseLength, 2));

Console.WriteLine($"\nThe hypotenuse of height: {height} and base {baseLength}) is: {hypotenuse.ToString("F2")}");
