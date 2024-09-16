// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;
using System.Diagnostics.Metrics;

//you can use special wildcard characters to enhance the appearance of your output
// adding a line \n
// tabbing \t
Console.WriteLine("\n\tEstimated Inventory Management Cost Savings\n\n");


//Detailed Steps
////data storage
//DECLARE inventoryManagementCosts as Float
//DECLARE estimatedPercentageSaved as Float
//DECLARE estimateAmountSaved as Float
////inputs
//PROMPT: Enter the cost of Inventory : [inventoryManagementCosts]
//PROMPT: Enter the savings percentage(ie 15.5)
//READ: [estimatedPercentageSaved]
////processing
//CALCULATE estimateAmountSaved = inventoryManagementCosts * (estimatedPercentageSaved / 100)
////output
//PRINT estimateAmountSaved(note dollar amount)

//literals in C# also must consider their datatype
//int no need for a datatype suffix
//double no need for a datatye suffix BUT optionally use a d
//decimal there is a need for a datatype suffix. It is a m
decimal inventoryManagementCosts = 0.0m, estimateAmountSaved;
double estimatedPercentageSaved;
string inputValue; //default of a string is null (null is the absence of data)

Console.Write("Enter the cost of Inventory :\t\t");
inputValue = Console.ReadLine();

//this logic assumes that valid data is entered by the user
inventoryManagementCosts = decimal.Parse(inputValue);

Console.Write("Enter the savings percentage(ie 15.5) :\t\t");
inputValue = Console.ReadLine();
estimatedPercentageSaved = double.Parse(inputValue);

//you can temporary alter the datatype of a variable using type-casting
//this does NOT alter the actaul datatype of the variable
//this tells the system to treat the following as the specific datatype
estimateAmountSaved = inventoryManagementCosts * (decimal)(estimatedPercentageSaved / 100);

Console.WriteLine($"\n\tThe estimate inventory cost savings is {estimateAmountSaved.ToString("C2")}");
// using the # and 0 when formating numerics will indicated optional digits (#) and required digits (0)
// you can also indicate whether a , separator is needed within your numeric output
Console.WriteLine($"\tThe estimate inventory cost savings is {estimateAmountSaved.ToString("#,##0.00")}");
