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
