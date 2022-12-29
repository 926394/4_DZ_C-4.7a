// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++) 
    {
        for (int j = 0; j < n; j++) 
            result[i, j] = new Random().Next(minValue, maxValue);

        
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

int ChoiceOfNumber( int m, int n, int[,] inArray )
{
    int result = 0;
    if(m <= inArray.GetLength(0) && n <= inArray.GetLength(1)&& m>0 && n>0)
    {
        for (int i = 0; i < inArray.GetLength(0); i++) 
        {
            for (int j = 0; j < inArray.GetLength(1); j++) 
            {
                if(i == m-1 && j == n-1)
                {
                result = inArray[i, j];
                Console.WriteLine($"Ответ: {result}");
                } 
                
            }
        }
    }
    else Console.WriteLine("Извините, такого элемента нет");
    return result;
}

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

Console.Write("Введите № строки элемента: ");
int r = int.Parse(Console.ReadLine()!);
Console.Write("Введите № столбца элемента: ");
int x = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, -10, 10);

PrintArray(array);
Console.WriteLine();
int array1 = ChoiceOfNumber(r, x, array);
Console.WriteLine();
// PrintArray(array1);