int UserRead()
{
    string N = Console.ReadLine() ?? "";
    int N_int = Convert.ToInt32(N);
    return N_int;
}
void FillArray(int N, int X, int Y)
{
    int[] array = new int[N];
    Random rand = new Random();
    for (int y = 0; y < N; y++)
    {
        array[y] = rand.Next(X, Y);
    }
    Console.Write("[ ");
    foreach (var i in array)
    {
        Console.Write("{0} ", i);
    }
    Console.Write("]");
}
while (true)
{
    Console.WriteLine("Введите минимальный порог случайных значений: ");
    int X = UserRead();
    Console.WriteLine("Введите максимальный порог случайных значений: ");
    int Y = UserRead();
    if (X > Y)
    {
        Console.WriteLine("Минимальный порог не может быть больше максимального. Попробуйте ещё раз: "); 
        continue;
    }
    Console.WriteLine("Введите количество элементов массива: ");
    int N = UserRead();
    FillArray(N, X, Y);
    break;
}


