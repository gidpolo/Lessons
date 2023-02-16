int UserRead()
{
    string N = Console.ReadLine() ?? "";
    int N_int = Convert.ToInt32(N);
    return N_int;
}
double[] FillArray(int N, double[] array)
{
    Random rand = new Random();
    for (int y = 0; y < N; y++)
    {
        array[y] = rand.Next(-100, 100) + rand.NextDouble();
    }
    return array;
}
void PrintArray(double[] array)
{
    Console.Write("[ ");
    foreach (var i in array)
    {
        Console.Write("{0:f2} ", i);
    }
    Console.Write("]");
}
double Max(double[] array)
{
    double max = array[0];
    foreach (var i in array)
    {
        if (i > max) max = i;
    }
    return max;
}
double Min(double[] array)
{
    double min = array[0];
    foreach (var i in array)
    {
        if (i < min) min = i;
    }
    return min;
}
while (true)
{
    int count = 0;
    Console.WriteLine("Разница max & min элементов массива.");
    Console.WriteLine("Введите размер массива: ");
    int N = UserRead();
    double[] array = new double[N];
    FillArray(N, array);
    PrintArray(array);
    double result = Max(array) - Min(array);
    Console.WriteLine("{0:f2}",result);
    break;
}