int UserRead()
{
    string N = Console.ReadLine() ?? "";
    int N_int = Convert.ToInt32(N);
    return N_int;
}

Console.WriteLine("Введите число, для того чтобы вывести все кубы чисел от 1 до вашего числа: ");
int N = UserRead();
int N1 = N;
int[] array = new int[N];
int j = 0;
Console.Write($"{N} -> ");
while (N1!=0)
{
    array[j]= j + 1;
    double c = Math.Pow(array[j], 3);
    j++;
    N1--;
    Console.Write($"{c} ");
}
