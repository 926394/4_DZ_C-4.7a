// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] GetArray(int m, int n)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++) // - "m" количество строк
    {
        for (int j = 0; j < n; j++) //- "n" количество столбцов// или точнее кол-во элементов в строке
        {
            result[i, j] = new Random().NextDouble()*10;
            // по 1 прогону идет так: resolt[0,0] = 5; result[0,1] = 2; result[0,2] = 4
            // по 2 прогону идет так: resolt[1,0] = 1; result[1,1] = 8; result[1,2] = 7
            // по 3 прогону идет так: resolt[2,0] = 12; result[2,1] = 11; result[2,2] = 10
        }
        
    }
    // Console.WriteLine(" " + Math.Round(result[m,n],2) + " ");
    return result;

}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            // Console.Write($" {inArray[i, j]} ");
            Console.Write($" {Math.Round(inArray[i, j],2)} ");
            
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

double[,] array = GetArray(rows, columns);

PrintArray(array);
