//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int [,] Create2dArray ()
{
    Console.Write("input count of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input count of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("input minimal possible value: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("input maximal possible value: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());
    int [,] CreatedArray = new int [rows , columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            CreatedArray [i , j] =(new Random().Next(minVal, maxVal+1));
        }
    }
    return CreatedArray;
}
void Show2dArray (int [,] array)
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

void Averege(int [,] array)
{
    for (int j=0; j < array.GetLength(1); j++)
    {   int sum = 0;
        for (int i=0; i < array.GetLength(0); i++)
        {   
            sum += array [i,j];
            Console.Write($"{sum}/{array.GetLength(0)}  ");
        }
        Console.WriteLine("<-- среднее арифметическое в последнем столбце ");
    }
    Console.WriteLine();
}

int[,] newArray = Create2dArray();
Show2dArray(newArray);
Averege(newArray);
