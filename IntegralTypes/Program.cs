// See https://aka.ms/new-console-template for more information

/* 
 * First, you must consider the digits of precision each type allows. Precision is the number of value places stored after the decimal point.
 *
 * Second, you must consider the manner in which the values are stored and the impact on the accuracy of the value. For example, float and double values are stored internally in a binary (base 2) format, 
 * while decimal is stored in a decimal (base 10) format. Why does this matter?
 *
 * Performing math on binary floating-point values can produce results that may surprise you if you're used to decimal (base 10) math.
 * Often, binary floating-point math is an approximation of the real value. Therefore, float and double are useful because large numbers can be stored using a small memory footprint.
 * However, float and double should only be used when an approximation is useful.
 * For example, being a few thousandths off when calculating the splatter of a snowball in a video game is close enough.
 * When you need more a more precise answer, you should use decimal. Each value of type decimal has a relatively large memory footprint, however performing math operations gives you a more precise result.
 * So, you should use decimal when working with financial data or any scenario where you need an accurate result from a calculation. 
 */

Console.WriteLine("Integral Types!");

Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");