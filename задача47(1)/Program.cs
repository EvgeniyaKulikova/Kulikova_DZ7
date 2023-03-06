//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double [,] Create2dArray ()
{
    Console.Write("input count of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input count of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("input minimal possible value: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("input maximal possible value: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());
    double [,] CreatedArray = new double [rows , columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            CreatedArray [i , j] = Math.Round((new Random().Next(minVal, maxVal+1)) + (new Random().NextDouble()), 2);
        }
    }
    return CreatedArray;
}
void Show2dArray (double[,]array)
{
    for (int i=0; i < array.GetLength(0); i++)
    {
        for (int j=0; j < array.GetLength(1); j++)
        {
            Console.Write(array [i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double [,] newArray = Create2dArray();
Show2dArray(newArray);