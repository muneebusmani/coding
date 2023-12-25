using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    public static void Main()
    {
        Number_Guessing_Game Game;
        Game= new Number_Guessing_Game();

        Random random = new Random();
        Game.start(random);
    }
}
class Number_Guessing_Game
{
    public void start(Random random)
    {
        Console.WriteLine("Choose Your Difficulty :\n" +
            "1. Easy\n" +
            "2. Medium\n" +
            "3. Hard\n");
        int.TryParse(Console.ReadLine(),out int difficulty);

        Thread.Sleep(100);
        Console.Clear();

        int number=0;
        int tries=0;
        int guess;
        string message = "";
        int limit = 0;
        switch (difficulty)
        {
            case 1:
                number = random.Next(6);
                tries = 0;
                limit = 5;
                message = "Guess The Number from 1-5 :";
                break;
            case 2:
                number = random.Next(11);
                tries = 1;
                limit = 10;
                message = "Guess The Number from 1-10 :";
                break;
            case 3:
                number = random.Next(101);
                tries = 2;
                limit = 100;
                message = "Guess The Number from 1-100 :";
                break;
            default:
                Console.WriteLine("Please Enter The Correct Number For the Corresponding Difficulty Level");
                Thread.Sleep(1000);
                Console.Clear();
                start(random);
                break;
        }
        do
        {
            Console.WriteLine(message);
            bool isNumber = int.TryParse(Console.ReadLine(), out guess);
            if (guess > limit | guess == 0)
            {
                Console.Clear();
                Console.WriteLine("Please Enter Your Guess Between The valid Range");
                Thread.Sleep(2000);
                Console.Clear();
                continue;
            }
            if (guess == number)
            {
                Thread.Sleep(100);
                Console.Clear();
                break;
            }
            Thread.Sleep(100);
            Console.Clear();
            if (!isNumber)
            {
                Console.WriteLine("Please Enter A Valid Number");
                Thread.Sleep(500);
                Console.Clear();
                continue;
            }
            if (tries == 2)
            {
                Console.Clear();
                Console.WriteLine("Game Over!");
                Environment.Exit(0);
            }
            tries++;
        }
        while (guess != number);
        Console.WriteLine("You Win!");
        Console.ReadKey();
    }
}