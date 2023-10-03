using System;
using System.Numerics;

class Program
{
    public static void Main(string[] args)
    {
        /*        int i = 10;*/
        /*while (i < 6)
        {
            Console.WriteLine(i);
            i++;
        }
                do
                {
                    Console.WriteLine(i);
                    i++;
                }
                while (i < 5);

            for(int i=0; i<=10; i++)
                {
                    Console.WriteLine(i);
                }

        Console.WriteLine("Enter Number which table You want");
        int table = int.Parse(Console.ReadLine());

        Thread.Sleep(1000);
        Console.Clear();

        Console.WriteLine("How Many Times?");
        int multiple = int.Parse(Console.ReadLine());

        Thread.Sleep(1000);
        Console.Clear();

        string message;
        for (int times = 1; times <= multiple; times++)
        {
            string answer = $"{table * times}";
            message = $"{table} X {times} = {answer}";
            Console.WriteLine(message);
        }*/

        /*        for (int number=0;   number<10;   number++)
                {
                    Console.WriteLine(number);
                    if(number == 5)
                    {
                        break;
                    }
                }
        */
        int number = 1;
        while (number < 10)
        {
            Console.WriteLine(number);
            if (number == 5)
            {
                break;
            }
            number++;
        }
        Console.ReadKey();
    }
}