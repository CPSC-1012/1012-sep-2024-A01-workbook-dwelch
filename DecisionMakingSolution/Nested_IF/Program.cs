// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n\tGames! Games! Games!\n ");

/*
 * Rock, Paper, Scissors Game
 * 
 * This will be a program which will randomly generate a value
 * to represent the rock, paper or scissors. The program will
 * invite a user to enter a value for rock, paper or scissors.
 * The program will then decide who is the winner or if the game
 * is a tie.
 * 
 * Name: Don Welch
 * 
 * Last Updated: Oct 4, 2024
 * 
 */

string inputValue;
Random rnd = new Random(); //this is the random generator
int machineChoice = 0;
int gamerChoice = 0;

//generate a value representing the machine
//.Next(inclusive, exclusive)
machineChoice = rnd.Next(0, 3);
//machineChoice = 1; //this value would be my hard-coded value for testing


Console.WriteLine("\nChoices: Scissors (0), Rock (1), Paper (2)");
Console.Write("Enter the number representing your choice:\t");

inputValue = Console.ReadLine();

//using the xxx.Prase() will attempt to convert your data WITHOUT ANY regard to whether
//  the data can actually be convert. If it fails, your program throws an exception which
//  if not handled will ABORT (CRASHHHHHHHH!!!!) your program
//gamerChoice = int.Parse(inputValue);

//there is another method that can be used to convert your data and at the same time
//  test if it can actually be done
//this is an example of defensive coding

//syntax: bool = xxx.TryParse(string, out variable)
//   where bool is the result of the attempted parsing (true (successful) or false (unable to convert))
//         xxx is the datatype
//         string is the original data
//         out is a required keyword
//         variable is the receive data store variable

//nice thing about this command is it can be used directly within an if condition
if (int.TryParse(inputValue, out gamerChoice))
{
    //true path (successful conversion of data)
    //the good data is already in gamerChoice
    //it was placed there during the execution of TryParse
    //compound condition
    //this is two conditions that must be meet
    //the two conditions are tested using logical operators (&& or ||)

    if (gamerChoice < 0 || gamerChoice > 2)
    {
        //this is doing validation within the program
        //this data is invalid
        //do not do any more game processing
        Console.WriteLine($"Your choice of {gamerChoice} is invalid");
    }
    else
    {
        //this data is valid
        //continue doing game processing

        //decide if the gamer choice beats the computer
        //what if:
        // gamer choose Scissors (if)
        // {
        //   the computer choose Scissors tie (if)
        //   the computer choose Rock computer wins (if)
        //   the computer choose Paper gamer wins (if)
        // }
        // gamer choose Rock
        //   the computer choose Scissors computer wins
        //   the computer choose Rock tie
        //   the computer choose Paper gamer
        // gamer choose Paper
        //   the computer choose Scissors computer wins
        //   the computer choose Rock gamer wins
        //   the computer choose Paper tie
        if (gamerChoice == 0)
        {
            //the program will exit the if structure when a writeline is executed
            if(machineChoice == 0)
            {
                Console.WriteLine("\n\tYou and the computer both chose scissor. It is a tie.");
            }
            else
            {
                if (machineChoice == 1)
                {
                    Console.WriteLine("\n\tYou chose scissors and the computer chose Rock. You lose.");
                }
                else
                {
                    Console.WriteLine("\n\tYou chose scissors and the computer chose Paper. You win.");
                }
            }
        }

        if (gamerChoice == 1)
        {
            //all ifs will be execute regardless of which writeline is executed
            if (machineChoice == 0)
            {
                Console.WriteLine("\n\tYou chose Rock and the computer chose Scissor. You win.");
            }
            if (machineChoice == 1)
            {
                Console.WriteLine("\n\tYou chose Rock and the computer chose Rock. It is a tie.");
            }
            if (machineChoice == 2)
            {
                Console.WriteLine("\n\tYou chose Rock and the computer chose Paper. You lose.");
            }
        }

        //use logical operators to do the decission making
        if (machineChoice == 0 && gamerChoice == 2)
        {
            Console.WriteLine("\n\tYou chose Paper and the computer chose Scissor. You lose.");
        }
        if (machineChoice == 1 && gamerChoice == 2)
        {
            Console.WriteLine("\n\tYou chose Paper and the computer chose Rock. You win.");
        }
        if (machineChoice == 2 && gamerChoice == 2)
        {
            Console.WriteLine("\n\tYou chose Paper and the computer chose Paper. It is a tie.");
        }
    }
}
else
{
    //false path (unable to convert the data, aka BAD DATA!!!!!!!
    Console.WriteLine($"Your entry of {inputValue} is invalid. Try Again.");
}




Console.WriteLine("Thank you for playing my game.");