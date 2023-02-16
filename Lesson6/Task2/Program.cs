int UserRead()
{
    string N = Console.ReadLine() ?? "";
    int N_int = Convert.ToInt32(N);
    return N_int;
}
double[] FillArray(double[] array)
{
    int i = 0;
    int count = 0;
    while (count != 4)
    {
        array[i] = UserRead();
        i++;
        count++;
    }
    return array;
}
void Intersectionpoint()
{
    double[] array = new double[4];
    FillArray(array);
    if ((array[1] == array[3]) && (array[0] == array[2]))

        Console.WriteLine("Прямые совпадают");

    else if (array[1] == array[3])

        Console.WriteLine("Прямые параллельны");

    else
    {
        double x = (array[2] - array[0]) / (array[1] - array[3]);
        double y = (array[1] * (array[2] - array[0])) / (array[1] - array[3]) + array[0];
        Console.WriteLine($"( {x} ; {y} )");
    }
    
}
Console.Write("Точка пересечения прямых.");
Console.WriteLine("Введите последовательно b1,k1,b2,k2: ");
Intersectionpoint();
