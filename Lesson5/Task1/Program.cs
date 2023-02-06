int UserRead()
{
    string N = Console.ReadLine() ?? "";
    int N_int = Convert.ToInt32(N);
    return N_int;
}
int[] FillArray(int N, int[] array)
{
    Random rand = new Random();
    for (int y = 0; y < N; y++)
    {
        array[y] = rand.Next(100, 999);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[ ");
    foreach (var i in array)
    {
        Console.Write("{0} ", i);
    }
    Console.Write("]");
}
while (true)
{
    int count = 0;
    Console.WriteLine("Количество чётных элементов в массиве.");
    Console.WriteLine("Введите размер массива: ");
    int N = UserRead();
    int[] array = new int[N];
    FillArray(N,array);
    PrintArray(array);
    foreach (var i in array)
    {
        if (i % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine($" --> {count}");
    break;
}