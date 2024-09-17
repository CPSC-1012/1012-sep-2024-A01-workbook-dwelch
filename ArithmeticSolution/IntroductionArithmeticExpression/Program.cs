// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n\tHello, World of Math Expression!\n\n");

int intA = 3, intB = 4, intC = 0;

//basic arithmetic operators

//addition
intC = intA + intB;
Console.WriteLine($"\nThe result of the math expression {intA} + {intB} is: {intC }\n");

//subtration
intC = intA - intB;
Console.WriteLine($"\nThe result of the math expression {intA} - {intB} is: {intC}\n");

//Multipication
intC = intA * intB;
Console.WriteLine($"\nThe result of the math expression {intA} * {intB} is: {intC}\n");

//Division
intC = intA / intB;
Console.WriteLine($"\nThe result of the math expression {intA} / {intB} is: {intC}");
intC = intB / intA;
Console.WriteLine($"\nThe result of the math expression {intB} / {intA} is: {intC}\n");

//Modular Division
//addition
intC = intA % intB;
Console.WriteLine($"\nThe result of the math expression {intA} % {intB} is: {intC}");
intC = intB % intA;
Console.WriteLine($"\nThe result of the math expression {intB} % {intA} is: {intC}\n");

double doubleA = 3, doubleB = 4, doubleC = 0;

//basic arithmetic operators

//addition
doubleC = doubleA + doubleB;
Console.WriteLine($"\nThe result of the math expression {doubleA} + {doubleB} is: {doubleC}\n");

//subtration
doubleC = doubleA - doubleB;
Console.WriteLine($"\nThe result of the math expression {doubleA} - {doubleB} is: {doubleC}\n");

//Multipication
doubleC = doubleA * doubleB;
Console.WriteLine($"\nThe result of the math expression {doubleA} * {doubleB} is: {doubleC}\n");

//Division
doubleC = doubleA / doubleB;
Console.WriteLine($"\nThe result of the math expression {doubleA} / {doubleB} is: {doubleC}");
doubleC = doubleB / doubleA;
Console.WriteLine($"\nThe result of the math expression {doubleB} / {doubleA} is: {doubleC}\n");

Console.WriteLine("\n\nCalculate an average\n");

double calculatedAverage = 0.0;
double numOne, numTwo, numThree;
string inputValue;

Console.Write("Enter your first number:\t");
inputValue = Console.ReadLine();
numOne = double.Parse(inputValue);
Console.Write("Enter your second number:\t");
inputValue = Console.ReadLine();
numTwo = double.Parse(inputValue);
Console.Write("Enter your third number:\t");
inputValue = Console.ReadLine();
numThree = double.Parse(inputValue);

calculatedAverage = (numOne + numTwo + numThree) / 3;

Console.WriteLine($"\nThe average of ({numOne}, {numTwo}, {numThree}) is: {calculatedAverage}");
Console.WriteLine($"The average of ({numOne}, {numTwo}, {numThree}) is: {calculatedAverage.ToString("F2")}");
Console.WriteLine($"The average of ({numOne}, {numTwo}, {numThree}) is: {calculatedAverage.ToString("#,##0.00")}");
Console.WriteLine($"The average of ({numOne}, {numTwo}, {numThree}) is: {Math.Round(calculatedAverage,2)}");