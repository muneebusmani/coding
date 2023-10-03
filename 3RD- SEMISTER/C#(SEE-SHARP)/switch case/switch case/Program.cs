using System.Transactions;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Your Number between (0-3)");
        int a = Convert.ToInt32(Console.ReadLine());
        // switch case in c#
        switch (a)
        {
            case 0:
                Console.WriteLine($"The value of a , according to case 0 is :   {a}");
                break;
            case 1:
                Console.WriteLine($"The value of a , according to case 1 is :   {a}");
                break;
            case 2:
                Console.WriteLine($"The value of a , according to case 2 is :   {a}");
                break;
            case 3:
                Console.WriteLine($"The value of a , according to case 2 is :   {a}");
                break;
            default:
                Console.WriteLine("Default Value");
                break;
        }
        Console.ReadKey();
    }
}