//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
int[,] Create2dArray()
{
    Console.Write("input count of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input count of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("input minimal possible value: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("input maximal possible value: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());
    int[,] CreatedArray = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                CreatedArray[i, j] = new Random().Next(minVal, maxVal + 1);
            }
        }
    return CreatedArray;
}
void Show2dArray(int[,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
     }
    Console.WriteLine();
}

void Find_element (int[,] array)
{
    Console.Write("input index a: ");
    int index_A = Convert.ToInt32(Console.ReadLine());
    Console.Write("input index b: ");
    int index_B = Convert.ToInt32(Console.ReadLine());
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (index_A <= array.GetLength(0) && index_B <= array.GetLength(1))
            {
              Console.WriteLine($"{array[index_A,index_B]} - such number is a array ");
              break;
            }
            else
            {
              Console.WriteLine($"such number is NOT a array "); 
            }

        } 
    }

}

int[,] newArray = Create2dArray();
Show2dArray(newArray);
Find_element(newArray);
    