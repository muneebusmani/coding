using System.Linq;

internal class Program
{
    private static void Main()
    {
        Console.WriteLine("What do u want to calculate? \n1.add\n2.subtract\n3.divide\n4.multiply");
        int operation = int.Parse(Console.ReadLine());

        Thread.Sleep(750);
        Console.Clear();

        const int add = 1;
        const int subtract = 2;
        const int divide = 3;
        const int multiply = 4;

        int[] operators = { add, subtract, divide, multiply };
        if (!operators.Contains<int>(operation))
        {
            print("Please Enter a Valid Respective value for the Listed Operators");
            Thread.Sleep(1000);
            Main();
        }
            
        Console.WriteLine("Enter First Number");
        int FirstNumber = int.Parse(Console.ReadLine());

        Thread.Sleep(750);
        Console.Clear();

        Console.WriteLine("Enter Second Number");
        int SecondNumber = int.Parse(Console.ReadLine());

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
                try
                {
                    double result = FirstNumber / SecondNumber;
                    string message = $"Your Answer is {result}";
                    print(message);
                }
                catch (Exception e)
                {
                    print(e.Message);
                    Thread.Sleep(2000);
                    Console.Clear();
                    Main();
                }
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
    public static string Add(double FirstNumber, double SecondNumber)
    {
        double result = FirstNumber + SecondNumber;
        return $"Your Answer is {result}";
    }
    public static string Subtract(double FirstNumber, double SecondNumber)
    {
        double result = FirstNumber - SecondNumber;
        return $"Your Answer is {result}";
    }
    public static string Multiply(double FirstNumber, double SecondNumber)
    {
        double result = FirstNumber * SecondNumber;
        return $"Your Answer is {result}";
    }
}