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
        array[y] = rand.Next(-100, 100);
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
    Console.WriteLine("Сумма элементов массива на нечётных позициях.");
    Console.WriteLine("Введите размер массива: ");
    int N = UserRead();
    int[] array = new int[N];
    FillArray(N, array);
    PrintArray(array);
    for (int i = 0; i < N; i += 2)
    {
        count+=array[i];
    }
    Console.WriteLine($" --> {count}");
    break;
}