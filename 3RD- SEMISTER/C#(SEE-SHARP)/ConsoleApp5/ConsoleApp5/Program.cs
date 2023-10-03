class Program
{
    public static void Main(string[] args)
    {
        /*        Console.WriteLine("Enter Your Name...");
                string name = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Enter Your age...");
                int age = int.Parse(Console.ReadLine());
                Console.Clear();
                print($"Hi There! my Name is {name} and i am {age} years old.");*/


        /*        print("Hello World");*/
        /*        print();              */
        /*Console.ReadKey();*/

        int value=print(2, 3);
        Console.WriteLine(value);
        //          or
        Console.WriteLine(print(2, 3));
    }
//                     reciever
/*    static void print(string args)
    {
        Console.WriteLine(args);
    }*/
/*    static void print()
    {
        Console.WriteLine("Hello World");
    }*/
    static int print(int val1,int val2)
    {
        return val1 + val2;
    }
}
