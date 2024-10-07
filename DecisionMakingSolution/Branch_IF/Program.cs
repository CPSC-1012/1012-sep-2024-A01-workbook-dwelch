// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n\tUsing Branch If Technique\n\n");

/*
 * 
 * Name: Don Welch
 * Last updated: Oct 7 2024
 * 
 * Problem:
 * Write a program that will determine the cost of admission for a theatre.  
 * The price of admission is based on the age of the customer.  
 * Your program should prompt the user for their age and then display the correct 
 * admission amount.  
 * 
 * Children 6 and under = FREE ($0.00) 
 * Students 7 to 17 = $9.80 
 * Adults 18 to 54 = $11.35 
 * Seniors 55+ = $10.00 
 * 
 * this problem can be solved using a nested if technique
 * it can also be solve using the branching if-else if technique
 * 
 * syntax:
 * 
 *   if (condition(s))                                      if(condition(s)
 *   {                                                      {
 *      true path                                               true path
 *   }                                                      }
 *   else if (condition(s)                                  else
 *   {                                                      {
 *      true path                                                if(condition(s)
 *   }                                                           {
 *   [else if (condition(s))                                         true path
 *    {                                                           }
 *       true path                                                else
 *    } ....]                                                     {  
 *   else                                                              .....
 *   {                                                             } 
 *      required                                             }   
 *      only false path (the "left overs")
 *   }
 */

int age = 0;
double admissionAmount = 0.0;
string inputValue = "";

Console.Write("Enter your age:\t");
inputValue = Console.ReadLine();
if (!int.TryParse(inputValue, out age))
{
    Console.WriteLine($"Your input of {inputValue} is not a number indicating your age.");
}
else
{
    if (age < 0)
    {
        Console.WriteLine($"Your age of {age} is not a valid age.");
    }
    else
    {
        //at this point in process
        //you can assume your data is valid

        //NOTE: the relative operator is NOT an equals
        //      this means this branch CANNOT be coded as a case-structure
        //      ALL case-structures can be coded as a branch structure BUT
        //              NOT all branch structures can be coded as a case structure
        if (age <= 6)
        {
            admissionAmount = 0.00;
        }
        else if(age > 6 && age <= 17) //valid but unnecessary age > 6 && 
        {
            admissionAmount = 9.80;
        }
        else if(age <= 54)
        {
            admissionAmount = 11.35;
        }
        else
        {
            admissionAmount = 10.00;
        }

        //coded as a nested if
        //if (age <= 6)
        //{
        //    admissionAmount = 0.00;
        //}
        //else
        //{
        //    if(age <= 17)
        //    {
        //        admissionAmount = 9.80;
        //    }
        //    else
        //    {
        //        if (age <= 54)
        //        {
        //            admissionAmount = 11.35;
        //        }
        //        else
        //        {
        //            admissionAmount = 10.00;
        //        }
        //    }
        //}


            Console.WriteLine($"\n\tA ticket for your age of {age} " +
            $"will cost ${admissionAmount.ToString("#0.00")}");
    }
}
