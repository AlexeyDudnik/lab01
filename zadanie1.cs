using System;
class Prog
{
    static void Main()
    {
        Console.WriteLine($"{sbyte.MinValue} - {sbyte.MaxValue}");
        Console.WriteLine($"{byte.MinValue} - {byte.MaxValue}");
        Console.WriteLine($"{float.MinValue} - {float.MaxValue}");
        Console.WriteLine($"{int.MinValue} - {int.MaxValue}");
        Console.WriteLine($"{short.MinValue} - {short.MaxValue}");
        Console.WriteLine($"{ushort.MinValue} - {ushort.MaxValue}");
        Console.WriteLine($"{uint.MinValue} - {uint.MaxValue}");
        Console.WriteLine($"{long.MinValue} - {long.MaxValue}");
        Console.WriteLine($"{ulong.MinValue} - {ulong.MaxValue}");
        Console.WriteLine($"{double.MinValue} - {double.MaxValue}");
        Console.WriteLine($"{decimal.MinValue} - {decimal.MaxValue}");
        Console.WriteLine($"{char.MinValue} - {char.MaxValue}");
        Console.WriteLine($"{bool.FalseString} - {bool.TrueString}");
    }
}
