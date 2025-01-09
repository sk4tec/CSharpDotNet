// See https://aka.ms/new-console-template for more information
/*
Standard Numeric Format Strings in C#:

1. Currency (`C` or `c`):
   - Formats the number as a currency value.
   - Example: 12345.6789.ToString("C") would output $12,345.68 (depending on the current culture).

2. Decimal (`D` or `d`):
   - Formats the number as a decimal integer.
   - Example: 123.ToString("D5") would output 00123.

3. Exponential (`E` or `e`):
   - Formats the number in scientific notation.
   - Example: 12345.6789.ToString("E") would output 1.234568E+004.

4. Fixed-point (`F` or `f`):
   - Formats the number as a fixed-point value.
   - Example: 12345.6789.ToString("F2") would output 12345.68.

5. General (`G` or `g`):
   - Formats the number in the most compact form: either fixed-point or scientific notation.
   - Example: 12345.6789.ToString("G") might output 12345.6789.

6. Number (`N` or `n`):
   - Formats the number with thousands separators.
   - Example: 12345.6789.ToString("N3") would output 12,345.679.

7. Percent (`P` or `p`):
   - Formats the number as a percentage.
   - Example: 0.1234.ToString("P2") would output 12.34%.

8. Hexadecimal (`X` or `x`):
   - Formats the number as a hexadecimal value.
   - Example: 255.ToString("X") would output FF.
*/

/*
Desired output:

Dear Ms. Barros,
As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.

Currently, you own 2,975,000.00 shares at a return of 12.75%.

Our new product, Glorious Future offers a return of 13.13%.  Given your current volume, your potential profit would be 63,000,000.00.

Here's a quick comparison:

Magic Yield         12.75%   $55,000,000.00      
Glorious Future     13.13%   $63,000,000.00
*/

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine($"Dear {customerName}");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:N3} shares at a return of {currentReturn:P}\n");

Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}. Given your current volume, your potential profit would be ${newProfit:N3}.\n");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage;

comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

// Your logic here
Console.WriteLine(comparisonMessage);