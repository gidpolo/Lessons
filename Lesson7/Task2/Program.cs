int UserRead()
{
    string N = Console.ReadLine() ?? "";
    int N_int = Convert.ToInt32(N);
    return N_int;
}
double[,] FillArray(int N, int M, double[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < M; j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-1000, 1000)) / 10;
        }
    }
    return array;
}
void PrintArray(double[,] array)
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
double[,] array = new double[N, M];
FillArray(N, M, array);
PrintArray(array);
Console.WriteLine("Ввывод элемента по индексу.");
Console.WriteLine("Введите строку:");
int T = UserRead() - 1;
Console.WriteLine("Введите столбец:");
int T1 = UserRead() - 1;
if (T > N || T1 > M)
{
    Console.WriteLine("Такого числа в массиве нет");
}
else
{
    Console.WriteLine(array[T, T1]);
}

