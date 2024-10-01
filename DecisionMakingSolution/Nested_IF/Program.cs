// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n\tGames! GAmes! Games!\n ");

//rock paper scissors

string inputValue;
Random rnd = new Random();
int machineChoice = 0;
int gamerChoice = 0;

machineChoice = rnd.Next(0, 3);
Console.WriteLine("Choices: Scissors (0), Rock (1), Paper (2)");
Console.Write("Enter the number representing your choice:\t");

inputValue = Console.ReadLine();
gamerChoice = int.Parse(inputValue);

//compound condition
//this is two conditions that must be meet
//the two conditions are tested using logical operators (&& or ||)

if(gamerChoice < 0 || gamerChoice > 2)
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
}

Console.WriteLine("Thank you for playing my game.");