using System;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your First Name");
        string FirstName=Console.ReadLine();

        Thread.Sleep(750);
        Console.Clear();

        Console.WriteLine("Enter your Last Name");
        string LastName=Console.ReadLine();

        Thread.Sleep(750);
        Console.Clear();

        string FullName = $"{FirstName} {LastName}";

        Console.WriteLine("Enter your Age");
        int Age = int.Parse(Console.ReadLine());

        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n" +
          $"| Full Name : {FullName}\n| Age : {Age}\n" +
           "------------------------------------------------------------------------------------------------------------------------");
           

        Console.WriteLine("What do u want to calculate? \n1.add\n2.subtract\n3.divide\n4.multiply");
        int operation=int.Parse(Console.ReadLine());

        Thread.Sleep(750);
        Console.Clear();

        const int add      = 1;
        const int subtract = 2;
        const int divide   = 3;
        const int multiply = 4;

        Console.WriteLine("Enter First Number");
        int FirstNumber=int.Parse(Console.ReadLine());

        Thread.Sleep(750);
        Console.Clear();

        Console.WriteLine("Enter Second Number");
        int SecondNumber=int.Parse(Console.ReadLine());

        Thread.Sleep(750);
        Console.Clear();

        switch (operation)
        {
            case add:
                print(Add(FirstNumber, SecondNumber));
                break;
            case subtract:
                print(Subtract(FirstNumber, SecondNumber));
                break;
            case multiply:
                print(Multiply(FirstNumber, SecondNumber));
                break;
            case divide:
                print(Divide(FirstNumber, SecondNumber));
                break;
            default:
                print("Error 404");
                break;
        }
        Console.ReadKey();
    }
    public static void print(string args)
    {
        Console.WriteLine(args);
    }
    public static string Add(int FirstNumber,int SecondNumber)
    {
        int result = FirstNumber + SecondNumber;
        return $"Your Answer is {result}";
    }    
    public static string Subtract(int FirstNumber,int SecondNumber)
    {
        int result = FirstNumber - SecondNumber;
        return $"Your Answer is {result}";
    }
    public static string Multiply(int FirstNumber,int SecondNumber)
    {
        int result = FirstNumber * SecondNumber;
        return $"Your Answer is {result}";
    }    
    public static string Divide(int FirstNumber,int SecondNumber)
    {
        int result = FirstNumber / SecondNumber;
        return $"Your Answer is {result}";
    }
}