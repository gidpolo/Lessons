int UserRead()
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

while (true)
{
    Console.WriteLine("Задайте размеры прямоугольного массива:");
    Console.WriteLine("Введите количество строк:");
    int N = UserRead();
    Console.WriteLine("Введите количество столбцов:");
    int M = UserRead();
    if (N == M)
    {
        Console.WriteLine("Вы ввели квадратный массив, попробуйте ещё раз.");
        continue;
    }
    int[,] array = new int[N, M];
    FillArray(N, M, array);
    Console.WriteLine("Сгенерированный массив: ");
    PrintArray(array);
    int[] ArrayForCount = new int[N];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            ArrayForCount[i] += array[i, j];
        }
    }
    for (int j = 0; j < ArrayForCount.GetLength(0); j++)
    {
        Console.Write("{0,6:F2} ", ArrayForCount[j]);
    }
    int result = ArrayForCount[0];
    int resultPosition = 0;
    for (int i = 1; i < ArrayForCount.Length; i++)
    {
        if (ArrayForCount[i] < result)
        {
            result = ArrayForCount[i];
            resultPosition = i+1;
        }
    }
    Console.WriteLine("");
    Console.WriteLine($"Строка с наименьшей суммой элементов: {resultPosition}");
    break;
}