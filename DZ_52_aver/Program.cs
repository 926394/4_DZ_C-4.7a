// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++) 
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[] FindSumNum(int[,] array)
{
    double []result = new double [array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[j] += array[i, j];     
        }
    }
        for (int i = 0; i < result.Length; i++)
        {
          Console.Write($"{ result[i]} ");
        }
    return result;     
}

double[] ResultNum(double[] numres)
{
    double []res = new double [numres.Length];
    
    for (int i = 0; i < numres.Length; i++)
    {
        res[i] = numres[i] / numres.Length ;
        Console.Write($"{ Math.Round(res[i],2)} ");
    }
    // Console.Write($"{ Math.Round(res[i],2)} ");
    return res;     
}

int[,] array = GetArray(3, 3, 5, 16);
Console.WriteLine();

PrintArray(array);
Console.WriteLine();

double []rus = FindSumNum(array);
Console.WriteLine();
Console.WriteLine();
ResultNum(rus);
Console.WriteLine();
