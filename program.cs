// Program.cs (C# .NET)
using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhập số thứ nhất: ");
        var a = double.Parse(Console.ReadLine() ?? "0");
        Console.Write("Nhập số thứ hai: ");
        var b = double.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine($"Tổng: {a + b}");
    }
}