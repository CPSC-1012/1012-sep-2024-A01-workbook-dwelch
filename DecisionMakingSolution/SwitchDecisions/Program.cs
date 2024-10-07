// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n\tSwitch Decisions : All things equal\n\n");

//there is a structure refered to as a case structure
//conditions:
//  a) there is a single argument to be check : machineChoice
//  b) that argument is check against a series of values: 0,1,2
//  c) the comparsion is EQUALS
//
//the C# command to use for a case structure is the switch
//syntax:
//      switch (argument)
//      {
//          case value:
//          {
//              C# logic to execute
//              break;
//          }
//          .
//          .
//          .
//          case value:
//          {
//              C# logic to execute
//              break;
//          }
//          default:
//          {
//              C# logic to execute
//              break;
//          }
//      }

/*
 * Write a program for an Internet service provider so they can calculate how much to bill their
 *   customers. The provider offers customers 3 packages:
 * PACKAGE COST CALCULATION
 * A $9.95 per month for up to 10 hours; additional hours are billed at $2.00 per hour
 * B $13.95 per month for up to 20 hours; additional hours are billed at $1.00 per hour
 * C $19.95 per month for unlimited hours
 *
 * The program should prompt for the letter of the service package (A, B, or C) and the number of
 *    hours they have used if either option A or B has been selected
 */

string inputValue;
char planid;
double hours = 0.0;
double planAmount = 0.00;

Console.Write("Enter your plan A, B or C:\t");
inputValue = Console.ReadLine();
if (!char.TryParse(inputValue, out planid))
{
    //char is a single character ('A') whereas a string ("A") can be 0,1 or more characters
    Console.WriteLine($"Your entry of >{inputValue}< is not a character but a string.");
}
else
{
    Console.Write("Enter your hours used:\t");
    inputValue = Console.ReadLine();
    if (!double.TryParse(inputValue, out hours))
    {
      
        Console.WriteLine($"Your entry of >{inputValue}< is not a number.");
    }
    else
    {
        if (hours <= 0)
        {

            Console.WriteLine($"Your entry of {hours} is not a postive number (greater or equal to 0).");
        }
        else
        {
            //in this example we will use a case structure
            //rules:
            //single argument to check: yes, planid
            //comparison is equals: yes
            //value list: 'A', 'B', or 'C'

            //since C# is case-sensitive, we need to ensure the value
            //  of the argument matches the case level of the case values
            //switch (char.ToUpper(planid)) //solving case-sensitivity way one
            switch (planid)
            {
                case 'A':  //planid == 'A'
                case 'a': //a second case is treated as a logical OR; solving case-sensitivity way two
                    {
                        //you may place any valid C# logic within a case
                        //9.95/month up to 10 hours, all other time is 2.00 / hr
                        if (hours <= 10.0)
                        {
                            planAmount = 9.95;
                        }
                        else
                        {
                            planAmount = 9.95 + (hours - 10) * 2.00;
                        }
                        Console.WriteLine($"For your plan {char.ToUpper(planid)} with {hours} hours used " +
                                    $"is going to cost ${planAmount.ToString("#,##0.00")}");
                        break;
                    }
                case 'B':  //planid == 'B'
                    {
                        //13.95/month up to 20 hours, all other time is 1.00 / hr
                        if (hours <= 20.0)
                        {
                            planAmount = 13.95;
                        }
                        else
                        {
                            planAmount = 13.95 + (hours - 20) * 1.00;
                        }
                        Console.WriteLine($"For your plan {char.ToUpper(planid)} with {hours} hours used " +
                                $"is going to cost ${planAmount.ToString("#,##0.00")}");
                        break;
                    }
                case 'C':  //planid == 'C'
                    {
                        //unlimited
                        planAmount = 19.95;
                        Console.WriteLine($"For your plan {char.ToUpper(planid)} with {hours} hours used " +
                                 $"is going to cost ${planAmount.ToString("#,##0.00")}");
                        break;
                    }
                default:
                    {
                        //many times this default is used as a "valdiation"
                        //  option in that if any of the above cases are not
                        //  meet, the argument value should be considered invalid
                        Console.WriteLine($"\n\tYour planid value of >{planid}< is invalid. Chose A, B or C.");
                        break;
                    }
            }//eos
           
        }
    }
}
