int[,] Multiplication(int[,] arrA, int[,] arrB)
{
    if (arrA.GetLength(1) != arrB.GetLength(0)) Console.WriteLine("Матрицы нельзя перемножить");
    int[,] r = new int[arrA.GetLength(0), arrB.GetLength(1)];
    for (int i = 0; i < arrA.GetLength(0); i++)
    {
        for (int j = 0; j < arrB.GetLength(1); j++)
        {
            for (int k = 0; k < arrB.GetLength(0); k++)
            {
                r[i, j] += arrA[i, k] * arrB[k, j];
            }
        }
    }
    return r;
}
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
Console.WriteLine("Задайте размеры двух матриц для их умножения:");
Console.WriteLine("Введите количество строк первой матрицы:");
int N = UserRead();
Console.WriteLine("Введите количество столбцов первой матрицы:");
int M = UserRead();
int[,] arrA = new int[N, M];
FillArray(N, M, arrA);
Console.WriteLine("Сгенерированный матрица: ");
PrintArray(arrA);

Console.WriteLine("Введите количество строк второй матрицы:");
int N1 = UserRead();
Console.WriteLine("Введите количество столбцов второй матрицы:");
int M1 = UserRead();
int[,] arrB = new int[N1, M1];
FillArray(N1, M1, arrB);
Console.WriteLine("Сгенерированный матрица: ");
PrintArray(arrB);
Console.WriteLine("Результат произведения");
PrintArray(Multiplication(arrA,arrB));
