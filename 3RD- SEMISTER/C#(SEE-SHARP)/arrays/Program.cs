class Program
{
    static void Main(string[] args)
    {
        run();
    }
    static void run()
    {
        /*        int[] MyArray = new int[] { 10, 20, 30, 40, 50, 60 };
                for (int i = 0; i < MyArray.Length; i++)
                {
                    Console.WriteLine($"The Current Element is {MyArray[i]}");
                }
                       int[][] TwoDimensionalArray = {
                            new int[]{ 0 , 1 },
                            new int[]{ 1 , 0 },
                        };
                        int[][][] ThreeDimensionalArray =
                        {
                            new int[][]{
                                new int[]{ 0 , 1 },
                                new int[]{ 1 , 0 },
                                new int[]{ 0 , 0 },
                                new int[]{ 1 , 1 },
                            },
                            new int[][]{
                                new int[]{ 0 , 1 },
                                new int[]{ 1 , 0 },
                                new int[]{ 0 , 0 },
                                new int[]{ 1 , 1 },
                            },
                            new int[][]{
                                new int[]{ 0 , 1 },
                                new int[]{ 1 , 0 },
                                new int[]{ 0 , 0 }, 
                                new int[]{ 1 , 1 },
                            },
                        };*/
        /*        int[,] TwoDimensionalArray = new int[3,3];
                TwoDimensionalArray[0,0] =1;
                TwoDimensionalArray[0,1] =2;
                TwoDimensionalArray[0,2] =3;

                TwoDimensionalArray[1,0] =4;
                TwoDimensionalArray[1,1] =5;
                TwoDimensionalArray[1,2] =6;

                TwoDimensionalArray[2,0] =7;
                TwoDimensionalArray[2,1] =8;
                TwoDimensionalArray[2,2] =9;

                for(int row = 0; row < 3; row++)
                {
                    for ( int column=0;column < 3; column++)
                    {
                        Console.WriteLine($"Row: {row} Column: {column} Value: {TwoDimensionalArray[row, column]}");
                    }
                }*/

        Console.WriteLine("Enter Your Desirable Rows");
        int.TryParse(Console.ReadLine(), out int rows);
        Thread.Sleep(20);
        Console.Clear();

        Console.WriteLine("Enter Your Desirable Columns");
        int.TryParse(Console.ReadLine(), out int columns);
        Thread.Sleep(20);
        Console.Clear();

        int[,] array = new int[rows, columns];

        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {
                Console.WriteLine($"Enter Your Value For row : {row} , Column : {column}");
                if(int.TryParse(Console.ReadLine(), out int value) )
                {
                    array[row, column] = value;
                    Thread.Sleep(500);
                    Console.Clear();
                }
                else
                {
                    run();
                }
            }
        }
        for (int row = 0;row < rows; row++)
        {
            for(int column = 0;column < columns; column++)
            {
                Console.WriteLine($"Row: {row} Column: {column} Value: {array[row, column]}");
            }
        }
        Console.ReadKey();
    var implicitlyTypedArray = new[] { 1, 2, 3, 4};
    }
}