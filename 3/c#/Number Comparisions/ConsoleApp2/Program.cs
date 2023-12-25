using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Enter your first number");
        int a=int.Parse(Console.ReadLine());

        Console.WriteLine("Enter your second number");
        int b = int.Parse(Console.ReadLine());

        string message = (a > b) ? "a is greater than b" : "b is greater than a";
        Console.WriteLine(message);

    }
}