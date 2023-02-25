﻿int UserRead()
{
    string N = Console.ReadLine() ?? "";
    int N_int = Convert.ToInt32(N);
    return N_int;
}
int[,] FillArray(int N, int M, int[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < M; j++)
        {
            array[i, j] = new Random().Next(-10, 10);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,6:F2} ", array[i, j]);
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк:");
int N = UserRead();
Console.WriteLine("Введите количество столбцов:");
int M = UserRead();
int[,] array = new int[N, M];
FillArray(N, M, array);
PrintArray(array);
Console.WriteLine("Среднее арифметическое каждого столбца.");
int count = 0;
for (int i = 0; i < M; i++)
{
    double C = 0;
    for (int j = 0; j < N; j++)
    {
        C += array[j, i];
    }
    C = C / N;
    count++;
    Console.WriteLine($"Среднее арифметическое столбца {count}: {C:F1}");
}