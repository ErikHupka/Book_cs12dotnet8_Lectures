BackgroundColor = ConsoleColor.Gray;
ForegroundColor = ConsoleColor.Black;

string rowSeparator = new string('-', count: 107);
WriteLine(rowSeparator);

string[] headers = { "Type", "Byte(s) of memory", "Min", "Max" };
WriteLine($"{headers[0], -10}{headers[1], -10}{headers[2], 40}{headers[3], 40}");

WriteLine(rowSeparator);

string[] types = { "sbyte", "byte", "short", "ushort", "int", "uint", "long", "ulong", "Int128", "UInt128", "Half", "float", "double", "decimal" };

WriteLine($"{types[0], -10}{sizeof(sbyte), -4}{sbyte.MinValue, 53}{sbyte.MaxValue, 40}");
WriteLine($"{types[1],-10}{sizeof(byte),-4}{byte.MinValue,53}{byte.MaxValue,40}");
WriteLine($"{types[2],-10}{sizeof(short),-4}{short.MinValue,53}{short.MaxValue,40}");
WriteLine($"{types[3],-10}{sizeof(ushort),-4}{ushort.MinValue,53}{ushort.MaxValue,40}");
WriteLine($"{types[4],-10}{sizeof(int),-4}{int.MinValue,53}{int.MaxValue,40}");
WriteLine($"{types[5],-10}{sizeof(uint),-4}{uint.MinValue,53}{uint.MaxValue,40}");
WriteLine($"{types[6],-10}{sizeof(long),-4}{long.MinValue,53}{long.MaxValue,40}");
WriteLine($"{types[7],-10}{sizeof(ulong),-4}{ulong.MinValue,53}{ulong.MaxValue,40}");

unsafe
{
    WriteLine($"{types[8],-10}{sizeof(Int128),-4}{Int128.MinValue,53}{Int128.MaxValue,40}");
    WriteLine($"{types[9],-10}{sizeof(UInt128),-4}{UInt128.MinValue,53}{UInt128.MaxValue,40}");
    WriteLine($"{types[10],-10}{sizeof(Half),-4}{Half.MinValue,53}{Half.MaxValue,40}");
}

WriteLine($"{types[11],-10}{sizeof(float),-4}{float.MinValue,53}{float.MaxValue,40}");
WriteLine($"{types[12],-10}{sizeof(double),-4}{double.MinValue,53}{double.MaxValue,40}");
WriteLine($"{types[13],-10}{sizeof(decimal),-4}{decimal.MinValue,53}{decimal.MaxValue,40}");