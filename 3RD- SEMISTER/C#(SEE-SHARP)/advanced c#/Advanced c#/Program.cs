class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int 
        rock = 1,
        paper = 2,
        scissors = 3,
        cpuTry = random.Next(1, 4),
        playerTry=cpuTry;

        print("Welcome to rock paper scissors game!");
        print("Press any key to Start the game");
        Console.ReadKey();

        switch (cpuTry)
        {
            case 1:
                print("rock");
                break;
            case 2:
                print("paper");
                break;
            case 3:
                print("scissors");
                break;

        }
        print("type the corresponding number for your choice");
        print("1. rock");
        print("2. paper");
        print("3. scissors");
        while(!int.TryParse(Console.ReadLine(),out playerTry)){
            Console.Clear();
            Thread.Sleep(100);
            Main(args);
        }

    }
    static void print(string s)
    {
        Console.WriteLine(s);
    }
}