int UserRead()
{
    string N = Console.ReadLine() ?? "";
    int N_int = Convert.ToInt32(N);
    return N_int;
}


int Check(int N)
{
    int N1 = 0;
    while (N != 0)
    {
        N1 = N1 * 10 + N % 10;
        N /= 10;
    }
    return N1;
}

Console.WriteLine("Введите число, чтобы узнать является ли оно палидромом: ");

while (true)
{
    int N = UserRead();
    if (N == Check(N)) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
    break;
}