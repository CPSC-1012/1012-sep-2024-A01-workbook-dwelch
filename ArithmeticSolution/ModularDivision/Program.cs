// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

Console.WriteLine("\n\tModular Divsion\n");

//Write a program that will generate a random up to a three-digit whole number. The program will
//then calculate the sum of the digits of the number, and then display both the number and its
//digit sum. (i.e. 123 -> sum = 6)

//detail steps
//DECLARE hundreds, tens, units as int
//DELCARE sumOfDigits as int
//DELCARE tempDigits as int
//DECLARE randomNumber as int

//processing
//CREATE rnd instance from Random
//SET randomNumber using rnd (limit 0 to 999)
//EXTRACT hundreds digit
//SET tempDigits to remainder
//EXTRACT tens digits
//SET units digits to remainder
//CALCULATE sumOfDigits using hundreds + tens + units

//output
//DISPLAY random number and sum of digits

Random rnd; //declares like this statment did NOT create the actual occurance (instance)
            //  of the object itself
            //this only indicates a hold spot for the generator when it is created
rnd = new Random(); //this statement requests that the system create a generator instance
                    //  for this program

//optionally
//can the above 2 statements be combined: YES
//Random rnd = new Random();

int hundreds = 0, tens = 0, units = 0, tempDigits = 0, sumOfDigits = 0;
int randomNumber;

//the following statment uses a generator method called .Next()
//we will supply a range to the method to limit the number that will be generated
//NOTE: the range is from your lower number (inclusive) to 1 less then the specified 
//          upper limit eg: 0 to 1000 will generate a number (inclusive) between 0 and 999

randomNumber = rnd.Next(0, 1000);

//hundreds digit
//integer division : gives no remainder value or decimal places
hundreds = randomNumber / 100;  //785 => 7

//obtain the remainder which is your tens and units digits
tempDigits = randomNumber % 100; //785 => 85

//tens digit
tens = tempDigits / 10; // 85 => 8

//units digits
units = tempDigits % 10; // 85 => 5

sumOfDigits = hundreds + tens + units;

Console.WriteLine($"The sum of digits for {randomNumber} is {sumOfDigits}.");