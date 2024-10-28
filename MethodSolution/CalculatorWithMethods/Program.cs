// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n\tSimple Calculator using Methods\n");

//author Don Welch
//last modified: Oct 28 2024
//Create a calculator demonstrating a modular approach to the solution



#region Driver
int num1 = 0;
int num2 = 0;
string choice = "";
double results = 0.0;
bool valid = false;
string symbol = "";

//get two numbers for the calculation
num1 = GetNumber("Enter your first number for your calculation");
num2 = GetNumber("Enter your second number for your calculation");

//display the choices of calculation within a menu
DisplayMenu();
choice = Console.ReadLine();

//decide and do the calculation
//switch structure
switch (choice.ToUpper())
{
    case "A":
        {
            results = num1 + num2;
            symbol = "+";
            valid = true;
            break;
        }
    case "B":
        {
            results = num1 - num2;
            symbol = "-";
            valid = true;
            break;
        }
    case "C":
        {
            results = num1 * num2;
            symbol = "*";
            valid = true;
            break;
        }
    case "D":
        {
            if (num2 != 0)
            {
                results = num1 / num2;
                symbol = "/";
                valid = true;
            }
            else
            {
                Console.WriteLine("\n\tDivision by zero (0) is not a valid operation.\n");
            }
            break;
        }
    default:
        {
            Console.WriteLine("Your menu choice is invalid. Try Again");
            break;
        }
}

//display of the calculation results
DisplayResults(num1, num2, results, valid, symbol);
#endregion

#region Methods
//methods
//void DisplayMenu() : this will display the menu for the calculator
static void DisplayMenu()
{
    //a method stub is the method header and any possible return statement

    //later you can add the code for your method
    Console.WriteLine("\nChoice the whole number calculation to preform.");
    Console.WriteLine("a) ADD.");
    Console.WriteLine("b) Subtract.");
    Console.WriteLine("c) Multiple.");
    Console.WriteLine("d) Division.");
    Console.Write("Enter your calculation choice:\t");
}

//int GetNumber(string prompt) : this will retreive a numeric value from the user and return the number
static int GetNumber(string prompt)
{
    //this method will retreive a numeric from the user
    //validate the incoming value is a number
    //this method will continue to execute until a user enters a number
    bool validFlag = false; //I assume the data is invalid
    string inputValue = "";
    int number = 0;

    while (!validFlag)
    {
       
        Console.Write($"{prompt}\t");
        inputValue = Console.ReadLine();
        if (!int.TryParse(inputValue, out number))
        {
            Console.WriteLine($"\tYour input of >{inputValue}< is not valid. Try again.");
        }
        else
        {
            validFlag = true;
        }//eof
    }//eol  end of loop
    return number;

    //method stub the return statement can contain a valid value
    //the return will be updated when you actually complete the coding
    //return 0;
}

//void DisplayResults(int num1, int num2, double results, bool valid, string symbol): this will
//  display the results of the requested calculation
static void DisplayResults(int num1, int num2, double results, bool valid, string symbol)
{
    //dsiplay the value entered into the method
    //valid will indicate if the calculation was successful (division by 0)
    if(valid)
    {
        Console.WriteLine($"{num1} {symbol} {num2} = {results}");
    }
}

#endregion
