using static System.Console;

void TraceLine(string s)
{
    for (int i = 0; i < s.Length; i++) Write("-");
    WriteLine();
}

// header
string formatted = $"{"Type",-10}{"Byte(s) of memory",-20}{"Min",30}{"Max",30}";
TraceLine(formatted);
WriteLine(formatted);
TraceLine(formatted);
// data
WriteLine($"{"sbyte",-10}{sizeof(sbyte),-20}{sbyte.MinValue,30}{sbyte.MaxValue,30}");
WriteLine($"{"byte",-10}{sizeof(byte),-20}{byte.MinValue,30}{byte.MaxValue,30}");
WriteLine($"{"short",-10}{sizeof(short),-20}{short.MinValue,30}{short.MaxValue,30}");
WriteLine($"{"ushort",-10}{sizeof(ushort),-20}{ushort.MinValue,30}{ushort.MaxValue,30}");
WriteLine($"{"int",-10}{sizeof(int),-20}{int.MinValue,30}{int.MaxValue,30}");
WriteLine($"{"uint",-10}{sizeof(uint),-20}{uint.MinValue,30}{uint.MaxValue,30}");
WriteLine($"{"long",-10}{sizeof(long),-20}{long.MinValue,30}{long.MaxValue,30}");
WriteLine($"{"ulong",-10}{sizeof(ulong),-20}{ulong.MinValue,30}{ulong.MaxValue,30}");
WriteLine($"{"float",-10}{sizeof(float),-20}{float.MinValue,30}{float.MaxValue,30}");
WriteLine($"{"double",-10}{sizeof(double),-20}{double.MinValue,30}{double.MaxValue,30}");
WriteLine($"{"decimal",-10}{sizeof(decimal),-20}{decimal.MinValue,30}{decimal.MaxValue,30}");
TraceLine(formatted);