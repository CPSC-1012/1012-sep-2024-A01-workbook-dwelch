// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n\tPartial Array Filling\n\n");

const int PHYSICALSIZE = 10;
int[] numbers = new int[PHYSICALSIZE];

/*
 * Arrays do not need to be completely filled
 * Arrays that are not completely filled are called partial array
 * One still needs to specify the full array size at declaration
 * With a partially filled array, one needs to track the actual number
 *      of elements that have "real meaningful" data
 * With the declaration of your array, the elements are set to the default
 *      data type value
 *      example: numeric arrays will be filled with zeros
 * to track the meaningful elements in the array we use another integer value
 * this value is usually referred to as the 'logical size'
 * Assumption: that the array is filled from index 0 onwards
 */

//this variable will track the number of real meaningful pieces of data
//this is also treated as a natural count
int logicalSize = 0;

string inputValue = "";
bool flag = true;
int num = 0;
int sumOfElements = 0;
double averageOfElements = 0.0;


while(flag) //1
{
    if (logicalSize == PHYSICALSIZE)  //1
    {
        //no more space to save data within the array
        //it is full
        flag =false;
        Console.WriteLine("\n\tArray is full\n");
    }
    else
    {
        Console.Write("Enter a positive non-zero number (enter a character to quit):\t");
        inputValue = Console.ReadLine();
        if(int.TryParse(inputValue, out num)) //2
        {
            //we have a number
            if (num <= 0)  //3
            {
                Console.WriteLine($"Your value of {num} is not a positive non-zero number. Try again.");
            }
            else
            {
                // need to store the data in the first available array element
                // your current logical count (natural number) can act as the
                //      index in the array AS LONG as the increment to your
                //      logical count is done AFTER the data is stored
                numbers[logicalSize] = num;

                //increment your logical size counter
                logicalSize++;
            }//eof 3
        }
        else
        {
            //we have a non-number
            //signal to quit
            flag = false;
        }//eof 2
    }//eof 1
}//eol 1

//the for loop will use the logical size to control when to exit the loop
//you can still loop through your entire array

//Console.WriteLine("\nfull array\n");
for (int index = 0; index < numbers.Length; index++)
{
    //Console.WriteLine($"The number at index {index} is the {index + 1}th element and is {numbers[index]}");
    sumOfElements += numbers[index];
}
averageOfElements = (double)sumOfElements / (double)PHYSICALSIZE;
Console.WriteLine($"The average of your data is {averageOfElements.ToString("##0.00")}");


averageOfElements = sumOfElements = 0;  //cute C#


//Console.WriteLine("\nworking data of the array\n");
for (int index = 0; index < logicalSize; index++)
{
    //Console.WriteLine($"The number at index {index} is the {index + 1}th element and is {numbers[index]}");
    sumOfElements += numbers[index];
}
averageOfElements = (double)sumOfElements / (double)logicalSize;
Console.WriteLine($"The average of your data is {averageOfElements.ToString("##0.00")}");

//Does partial arrays affect how built-in methods work?
//NO
//Does partial arrays affect the expected result of built-in methods?
//YES

//lets take sorting as an example
//Sort the full array
//Array.Sort(numbers);
//Console.WriteLine("\nfull array sorted\n");
//for (int index = 0; index < numbers.Length; index++)
//{
//    Console.WriteLine($"The number at index {index} is the {index + 1}th element and is {numbers[index]}");
//    sumOfElements += numbers[index];
//}

//Sort the partial array
Array.Sort(numbers,0,logicalSize);
Console.WriteLine("\npartial array sorted\n");
for (int index = 0; index < numbers.Length; index++)
{
    Console.WriteLine($"The number at index {index} is the {index + 1}th element and is {numbers[index]}");
    sumOfElements += numbers[index];
}