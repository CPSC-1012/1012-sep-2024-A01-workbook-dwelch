// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n\tRound and Round and Round we go!!!\n\n");

///<summary>
///
/// Name: Don Welch
/// Last Modified: Oct 8 2024
/// 
/// Find the sum of the squares of the integers from 1 to MySquare, where MySquare is input by the user.  
/// E.g. user enters 4 then return 1x1 + 2x2 + 3x3 + 4x4 = 30
/// 
/// Detail Steps
/// DECLARE inputValue as string
/// DECLARE mySquare as int
/// DECLARE sumOfSquares as int
/// DELCARE loopCounter as int intialize to 1
/// 
/// REPEAT WHILE input is invalid
///     Prompt "Enter the integer upper square number to sum"
///     READ inputValue
///     check inputvalue to be valid
///       if no display an appropriate message
///       if yes SET mySquare to inputValue
/// end loop
/// 
/// REPEAT WHILE loop counter <= MySquare
///     Calculate the square of the loop counter
///     Add to the sum of the squares (sumOfSquares)
///     increment the loop counter by +1
///     DISPLAY the calculate as (loopcounter X loopcounter)
/// END LOOP
/// DISPLAY the final sum of squares.
/// 
/// </summary>
/// 

int mySquare = 0; //if you are using the variable in loop control ensure it has a expected starting value
int sumOfSquares = 0;
int loopCounter = 1;
string inputValue;

//possible stoping conditions
//a) mySquare > 0 ( continue while mySquare < 0 )
//b) boolean flag where true is valid data, false is invalid data

bool validFlag = false; //I assume the data is invalid

//while(!validFlag) //do the loop while the condition is true
while(mySquare < 1)
{
    //input my square number and continue looping until a valid number is entered
    Console.Write("Enter a positive whole number to create a sum of squares:\t");
    inputValue = Console.ReadLine();
    //defensive validation where the check is done before the data is attempted to
    //  be used in the expected proper format
    if (!int.TryParse(inputValue, out mySquare))
    {
        Console.WriteLine($"\tYour input of >{inputValue}< is not valid. Try again.");
        //exiting loop to eof/eol
    }
    else
    {
        //limit or range validation
        //is the data value in the expected domain
        if (mySquare < 1)
        {
            Console.WriteLine($"\tYour input of >{mySquare}< is not a positive whole number. Try again.");
            //exiting loop to eof/eol
        }
        //else
        //{
        //    //data is value
        //    //how do I stop the iterations
        //    //change your stoping condition to the stop value
        //    validFlag = true;
        //    //exiting loop to eof/eol
        //}
    }//eof
}//eol  end of loop
Console.WriteLine($"\nYou entered {mySquare}.\n");

Console.Write($"\n\tThe sum of squares for {mySquare} is: ");

//solution using a while() loop
//  is usually used when there is an known number of times thru the loop

//while(loopCounter <= mySquare)
//{

//    sumOfSquares += loopCounter * loopCounter;
//    Console.Write($"{loopCounter}X{loopCounter}");
//    if (loopCounter < mySquare)
//    {
//        Console.Write(" + ");
//    }
//    else
//    {
//        Console.Write(" = ");
//    }
//    //increment your loop counter
//    //loopCounter = loopCounter + 1;
//    //loopCounter += 1;
//    loopCounter++; //increment of +1
//}//eol

//solution using a for() loop
//also known as the counter loop
//this loop with execute x number of times
//syntax of the for loop
//      for(declaration and initialization of counter; continue condition; increment of loop counter)
//      {
//        loop logic
//      }
//if you declaration your loop counter within the for statement, the loop counter DIES at the termination
//  of your loop (goes out of scope)

for ( int counter = 1; counter <= mySquare; counter++) 
{

    sumOfSquares += counter * counter;
    Console.Write($"{counter}X{counter}");
    if (counter < mySquare)
    {
        Console.Write(" + ");
    }
    else
    {
        Console.Write(" = ");
    }
   
}//eol



Console.Write($"{sumOfSquares}\n");