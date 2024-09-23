// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

Console.WriteLine("\n\tCan do more then eat PI\n");

//Write a program that reads in the radius and length of a cylinder and computes
//the area and volume using the formulas:

//area = radius ∗ radius ∗ 𝜋𝜋
//volume = area ∗ length

//Detail steps
// (.....)

double radius = 0;
double length = 0;
double area = 0;
double volume = 0;
string inputValue = "";
const double PI = 3.141592;

Console.Write("Enter the cylinder radius:\t");
inputValue = Console.ReadLine();
radius = double.Parse(inputValue);

Console.Write("Enter the cylinder length:\t");
inputValue = Console.ReadLine();
length = double.Parse(inputValue);

area = radius * radius * PI;
//area = radius * radius * double.Pi; 
//area = radius * radius * Math.PI;
//area = Math.Pow(radius,2) * Math.PI;

volume = area * length;

//round the answer to 4 decimal places
Console.WriteLine($"The cylinder with a radius of {radius} and length of {length} has " +
    $"an area of {area.ToString("F4")} and volume of {volume.ToString("###0.0")}");