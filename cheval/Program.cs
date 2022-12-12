internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("give grid dimentions:");
        Console.Write("rows : ");
        int colLength = int.Parse(Console.ReadLine());
        Console.Write("colomns : ");
        int rowLength = int.Parse(Console.ReadLine());

        string[,] matrix = new string[rowLength, colLength];

        createGrid(rowLength, colLength, matrix);
        matrix[colLength - 1, 0] = " X ";

        drawGrid(rowLength, colLength, matrix);

        Console.WriteLine("give target position:");
        Console.Write("target x :  ");
        int targetX = int.Parse(Console.ReadLine());
        Console.Write("target y : ");
        int targetY = int.Parse(Console.ReadLine());
        matrix[targetX, targetY] = " T ";

        drawGrid(rowLength, colLength, matrix);













        //drawGrid(rowLength, colLength, matrix);
    }
    public static void createGrid(int rowLength, int colLength, string[,] matrix)
    {
        for (int i = 0; i < rowLength; i++)
        {
            for (int j = 0; j < colLength; j++)
            {
                matrix[i, j] = " . ";
            }
        }

    }
    public static void drawGrid(int rowLength, int colLength, string[,] matrix)
    {
        for (int i = 0; i < rowLength; i++)
        {
            for (int j = 0; j < colLength; j++)
            {
                Console.Write(string.Format("{0} ", matrix[i, j]));
            }
            Console.Write(Environment.NewLine + Environment.NewLine);
        }


    }
}

//create grid matrix
// place random point
//excute up move function or right move function 
//mark the path  with vertical mark func or horizontal mark func
// if target is within the 8 scope then excute the big-L attack func
// mark the path with each move
// draw grid matrix