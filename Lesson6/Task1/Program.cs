int UserRead()
{
    string N = Console.ReadLine() ?? "";
    int N_int = Convert.ToInt32(N);
    return N_int;
}
int[] FillArray(int[] array, int N)
{
    int i = 0;
    while (N != 0)
    {
        array[i] = UserRead();
        i++;
        N--;
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
    int count = 0;
    Console.Write("Кол-во чисел которое хотите ввести: ");
    int N = UserRead();
    int[] array = new int[N];
    Console.WriteLine($"Введите {N} чисел");
    FillArray(array, N);
    PrintArray(array);
    foreach (var i in array)
    {
        if (i > 0) count++;
    }
    Console.WriteLine($" --> {count}");