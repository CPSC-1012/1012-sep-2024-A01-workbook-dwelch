// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n\tTic Tac Tow Game");

//Name: don Welch
//last modified Nov 1 2024

//Simply version of the classic Tic Tac Toe game. This will demonstrate multi-dimensional arrays

/************************************ driver *****************************/

//multi-dimensional array
//2 or more values within a row on your array

//game board

//              *          *
//        1     *    2     *      3                 this area would be a row
//              *          *
//    **************************************
//              *          *
//        4     *     5    *       6                this area would be a row
//              *          *
//    **************************************
//              *          *
//         7    *     8    *       9               this area would be a row
//              *          *
//     column     column        column



//the array STILL must be of a single datatype
//the rows vs columns do not need to match
//syntax string[ , ] indicates a 2 dimensional array (2D-array)
//                   the comma indicates each additional dimension (3D [,,])
//in a 2D array, the first value is your rows, the second value is the columns
string[,] gameBoard = new string[5, 5];

InitializeGameBoard(gameBoard);
DisplayGameBoard(gameBoard);
PlayTheGame(gameBoard);

#region Methods
static void InitializeGameBoard(string[,] gameBoard)
{
    //we know the exact number of rows and columns that need to be set
    //the type of loop would be a counter loop: for
    for (int r = 0; r < 5; r++)
    {
        //for each row, set all the columns
        for (int c = 0; c < 5; c++)
        {
            if (c == 1 || c == 3)
            {
                gameBoard[r, c] = "|";
            }
            else if (r == 1 || r == 3)
            {
                gameBoard[r, c] = "-".PadLeft(3, '-');
            }
            else
            {
                gameBoard[r, c] = "   ";
            }
        }
    }
    gameBoard[0, 0] = " 1 ";
    gameBoard[0, 2] = " 2 ";
    gameBoard[0, 4] = " 3 ";
    gameBoard[2, 0] = " 4 ";
    gameBoard[2, 2] = " 5 ";
    gameBoard[2, 4] = " 6 ";
    gameBoard[4, 0] = " 7 ";
    gameBoard[4, 2] = " 8 ";
    gameBoard[4, 4] = " 9 ";
}

static void DisplayGameBoard(string[,] gameBoard)
{
    for(int r = 0; r < 5; r++)
    {
        for (int c = 0; c < 5; c ++)
        {
            Console.Write(gameBoard[r, c]);
        }
        Console.WriteLine();
    }
}

static void PlayTheGame(string[,] gameBoard)
{
    int turns = 0; // maximum number of possible turns in the game
    int elementId = 1; //is the game position to play
    bool valid = false; //a flag to indicate if the turn was a valid turn
                        //a player could accidently try and play in a position
                        //      that is already taken
                        //this flag will indicate if the turn was correctly done

    while (turns < 9) //there are 9 possible turns in the game
    {
        if (turns % 2 == 0) //if the result is 0 it is X turn else it is O turn
        {
            //first person is X
            elementId = PromptForPlace("Player X: select an usused cell number");
            valid = PlaceSymbol(" X ", elementId, gameBoard);
        }
        else
        {
            //second person is O
            elementId = PromptForPlace("Player O: select an usused cell number");
            valid = PlaceSymbol(" O ", elementId, gameBoard);
        }
        Console.WriteLine();
        DisplayGameBoard(gameBoard);
        if (valid) //was it a good play??
        {
            // TODO:
            // create a method that would check to see if there is a 
            //  winner to the game
            // Sturctured quick loop exit by setting the loop sentinal identicator to a terminating value
            // An unstructured exit would use the key words: exit, return, break, AND these are UNACCEPTABLE in this class.
            // turns = CheckForWin(gameboard,turns);
            turns++;
        }
    }
}

static int PromptForPlace(string prompt)
{
    //the task of this method is to get a number
    // NOT a positive number
    // NOT a negative number
    // NOT a number between a and b or less than c or greater d
    // BUT JUST a number
    bool valid = false;
    string inputValue = "";
    int userGuess = 0;
    do
    {
        valid = true; //assume the user can give a valid integer input

        Console.Write($"{prompt}\t");
        inputValue =Console.ReadLine();
        if (!int.TryParse(inputValue, out userGuess))
        {
            Console.WriteLine($"\n\tInput Error: >{inputValue}<");
            valid = false;
        }
    } while (!valid);
    return userGuess;
}

static bool PlaceSymbol(string symbol, int elementId, string[,] gameBoard)
{
    bool valid = false;

    //decide which game position to check
    switch(elementId)
    {
        case 1:
            {
                //is the position filled? [0,0]
                if (gameBoard[0,0].Equals(" X ") || gameBoard[0,0].Equals(" O "))
                {
                    //filled
                    Console.Write("That game position is already in use. Choose a different game position.");
                }
                else
                {
                    //position is free
                    gameBoard[0, 0] = symbol;
                    valid = true;
                }

                break;
            }
        case 2:
            {
                //is the position filled? [0,2]
                if (gameBoard[0, 2].Equals(" X ") || gameBoard[0, 2].Equals(" O "))
                {
                    //filled
                    Console.Write("That game position is already in use. Choose a different game position.");
                }
                else
                {
                    //position is free
                    gameBoard[0, 2] = symbol;
                    valid = true;
                }

                break;
            }
        case 3:
            {
                //is the position filled? [0,4]
                if (gameBoard[0, 4].Equals(" X ") || gameBoard[0, 4].Equals(" O "))
                {
                    //filled
                    Console.Write("That game position is already in use. Choose a different game position.");
                }
                else
                {
                    //position is free
                    gameBoard[0, 4] = symbol;
                    valid = true;
                }

                break;
            }
        case 4:
            {
                //is the position filled? [2,0]
                if (gameBoard[2, 0].Equals(" X ") || gameBoard[2, 0].Equals(" O "))
                {
                    //filled
                    Console.Write("That game position is already in use. Choose a different game position.");
                }
                else
                {
                    //position is free
                    gameBoard[2, 0] = symbol;
                    valid = true;
                }

                break;
            }
        case 5:
            {
                //is the position filled? [2,2]
                if (gameBoard[2, 2].Equals(" X ") || gameBoard[2, 2].Equals(" O "))
                {
                    //filled
                    Console.Write("That game position is already in use. Choose a different game position.");
                }
                else
                {
                    //position is free
                    gameBoard[2, 2] = symbol;
                    valid = true;
                }

                break;
            }
        case 6:
            {
                //is the position filled? [2,4]
                if (gameBoard[2, 4].Equals(" X ") || gameBoard[2, 4].Equals(" O "))
                {
                    //filled
                    Console.Write("That game position is already in use. Choose a different game position.");
                }
                else
                {
                    //position is free
                    gameBoard[2, 4] = symbol;
                    valid = true;
                }

                break;
            }
        case 7:
            {
                //is the position filled? [4,0]
                if (gameBoard[4, 0].Equals(" X ") || gameBoard[4, 0].Equals(" O "))
                {
                    //filled
                    Console.Write("That game position is already in use. Choose a different game position.");
                }
                else
                {
                    //position is free
                    gameBoard[4, 0] = symbol;
                    valid = true;
                }

                break;
            }
        case 8:
            {
                //is the position filled? [4,2]
                if (gameBoard[4, 2].Equals(" X ") || gameBoard[4, 2].Equals(" O "))
                {
                    //filled
                    Console.Write("That game position is already in use. Choose a different game position.");
                }
                else
                {
                    //position is free
                    gameBoard[4, 2] = symbol;
                    valid = true;
                }

                break;
            }
        case 9:
            {
                //is the position filled? [4,4]
                if (gameBoard[4, 4].Equals(" X ") || gameBoard[4, 4].Equals(" O "))
                {
                    //filled
                    Console.Write("That game position is already in use. Choose a different game position.");
                }
                else
                {
                    //position is free
                    gameBoard[4, 4] = symbol;
                    valid = true;
                }

                break;
            }
        default:
            {
                //this is where I will validate that the position is a valid 1-9 value
                //YES: this could have been done in the prompting for the number
                //      HOWEVER, that would restrict the prompting for the number method
                //      to ONLY work for a situation where the number is between 1-9
                Console.Write("You game position is invalid. Choose between 1 - 9.");
                break;
            }
    }
    return valid;
}
#endregion

