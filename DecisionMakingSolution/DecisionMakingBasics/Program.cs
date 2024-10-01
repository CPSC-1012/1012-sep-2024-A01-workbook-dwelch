// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.WriteLine("\n\tDecisions Decisions Decisions ... What to do?\n\n");

/*
 * this is a comment block
 * 
 * Decisions control the flow of your critical paths through your program
 * 
 * All program languages use same reserved word for this command
 * C# uses the keyword: if/else
 * C# has several structures that can do flow-of-control
 * 
 * One-way path
 *     if (condition) {true action}
 *     
 * two-way path
 *     if (condition) {true action} else {false action}
 *     
 * branching path
 *     if (condition) {true action} else if(condition) {true action} ... else {false path}
 *     
 * case structure
 *     switch(argument) {case value: {case path; break;} ... default: {false path; break:}}
 *     
 * rules;
 *  the { } around your true/false actions are optional IF and ONLY IF the code is a single statement
 *      in the action OTHERWISE the brackets are required
 *      
 *  else is optional, if only a one-way path is needed
 *  
 *  true path is required
 *  
 *  You can nested if structures within other if structures: Nested-IF
 * 
 * Your program can continue with additional logic after an if structure
 * 
 */

//one way if
//this has no false path logic

//do I pay taxes?
//if so what is my tax amount

//the resolution of your if condition(s) is either true or false (boolean value)
bool taxable = false;
int quantity = 5;
double gst = 0.05;
double price = 2.75;
double tax = 0.00;

//is the item taxable?

//the if conditions consists of an argument; a comparison condition; value
//the argument and value can be variables or literals
// comparaion conditions
//
//relative operators
// equals: ==
// greater than: >
// less than: <
// greater than or equal: >=
// less than or equal: <=
// not equal: != or <>

//when more than one condition is used
//
//logical operators
// and: &&
// or: ||

//Bitwise operators
//works are the binary value level
//and: &
//or:  |

//examples
// (a > c)  : value a is greater than value c
// ((a + b) > c) : the espression value of (a + b) is grater than value c
//  1) sum of a + b is done
//  2) compares to c
//  3) resolves to a boolean true or false

//if(taxable == true)
if(taxable)   //this short form is possible because the variable is a boolean variable
{
    //true path
    //because there is only one statement in the true path
    //  the braces {...} are optional
    tax = (quantity * price) * gst;
}

Console.WriteLine($"The tax on my {quantity} items each priced at " +
    $" ${price.ToString("#,##0.00")} with a tax rate of {gst * 100}% is " +
    $" ${tax.ToString("#,##0.00")}");

/*
 * Write a program that lets the user guess whether the flip of a coin results in 
 *          heads or tails. 
 * The program randomly generates an integer 0 to 1, which represents head or tail. 
 * The program prompts the user to enter a guess, and reports whether the guess is 
 * correct or incorrect. 
 */

string inputValue;
int guess = 0;
Random rnd = new Random(); //random number generator
//generate the computer flip
int flip = rnd.Next(0, 2); //range values are (inclusive,exclusive)
Console.Write("\n\nEnter 1 for tails or 0 for heads:\t");
inputValue = Console.ReadLine();
guess = int.Parse(inputValue);

//decide whether the user has guessed correctly and output an appropriate message

//there is two possible outcomes: a) correct guess or b) incorrect guess
//this is a two-path structure
//this will required the > else < in my decision logic

if (flip == guess)
{
    Console.WriteLine($"\tYour guess of {guess} matches the flip of {flip}");
    //after executing the path, your program continues to the next statement
    //  following the if structure (eoc)
}
else
{
    Console.WriteLine($"\tYour guess of {guess} foes not matches the flip of {flip}");
    //after executing the path, your program continues to the next statement
    //  following the if structure (eoc)
}//eoc end of condition

//continuing progrma logic
Console.WriteLine("\nthis is the next line after the decision in your program");