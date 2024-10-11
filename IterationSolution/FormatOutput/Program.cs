// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n\tFormat of String Output!\n");

Random rnd = new Random();

double someNumber = 15264.23;
double smallNumber = 609.90;

DateTime someDate = DateTime.Today;

//using .ToString()
// using the system C for currency, defaults to 2 decimal places
//      however you can place a number after the C to increase the 
//      number of decimal places C2 - 2 decimals, C3 - 3 decimals, etc.
//customizing your own layout using the # and 0 for digits
//      where # is an optional digit and will not be displayed if it is not needed
//            0 will display a digit from 0-9
//      you can add your own , (3 digit breaks) and your own decimal .
Console.WriteLine("using the .ToString() method\n");
Console.WriteLine($"{someNumber.ToString("C")}");
Console.WriteLine($"{someNumber.ToString("#,##0.00")}");
Console.WriteLine($"{smallNumber.ToString("#,##0.00")}");
//for month you can use MM, MMM, MMMM
Console.WriteLine($"{someDate.ToString("MMM dd yyyy")}");

//using format string
//syntax Console.WriteLine("literals string using an {index:format} [{index:format}]", value(s))
//   where the index refers to the value order and format the format to apply
//       Console.WriteLine($"string.Format("index:format",value)");
Console.WriteLine("\n\nusing the format string \n");
Console.WriteLine("{0:C2} {1:#,##0.00}", smallNumber, rnd.Next(1, 10000));
Console.WriteLine($"{string.Format("{0:C2} {1:#,##0.00}", someNumber, rnd.Next(1, 10000))}");

//using alignment on formats
//snytax {index,alignment:format}
//   where alignment is the number of columns to use to display the value
//   where -alignment is left justified
//   where +alignment is right justified

//General alignment rules for output unless stated otherwise by your user
// strings (left)
// numerics (right)
// strings/numerics that have only one size for any value are centered

Console.WriteLine("\n\nusing alignment on the format string \n");
Console.WriteLine("123456789012345678901234567890");
Console.WriteLine("{0,-15:C2}-{1,10:#,##0.00}", smallNumber, rnd.Next(1, 10000));
Console.WriteLine($"{string.Format("{0,-15:C2}-{1,10:#,##0.00}", someNumber, rnd.Next(1, 10000))}");
