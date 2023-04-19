// 1. Number of bytes in memory
Console.WriteLine("Size of sbyte: {0} bytes", sizeof(sbyte));
Console.WriteLine("Size of byte: {0} bytes", sizeof(byte));
Console.WriteLine("Size of short: {0} bytes", sizeof(short));
Console.WriteLine("Size of ushort: {0} bytes", sizeof(ushort));
Console.WriteLine("Size of int: {0} bytes", sizeof(int));
Console.WriteLine("Size of uint: {0} bytes", sizeof(uint));
Console.WriteLine("Size of long: {0} bytes", sizeof(long));
Console.WriteLine("Size of ulong: {0} bytes", sizeof(ulong));
Console.WriteLine("Size of float: {0} bytes ", sizeof(float));
Console.WriteLine("Size of double: {0} bytes", sizeof(double));
Console.WriteLine("Size of decimal: {0} bytes", sizeof(decimal));

// 2. Convert century
Console.WriteLine("\nEnter the number of centuries:");
int centuries = Convert.ToInt32(Console.ReadLine());
long years = centuries * 100;
long days = (years * 365) + (centuries * 24);
long hours = days * 24;
long minutes = hours * 60;
long seconds = minutes * 60;
long milliseconds = seconds * 1000;
long microseconds = milliseconds * 1000;
long nanoseconds = microseconds * 1000;

Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds", centuries, years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds);
