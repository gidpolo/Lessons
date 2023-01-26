System.Console.WriteLine("Введите число, чтобы узнать третью цифру этого числа: ");

int UserRead()
{
    string N = Console.ReadLine() ?? "";
    int N_int = Convert.ToInt32(N);
    return N_int;
}

while (true)
{
    int N = UserRead();
    if (N < 100)
    {
        System.Console.WriteLine("Вы ввели число у которого нет третьей цифры, попробуйте снова: ");
        continue;
    }

    while (N>1000)
    {
        N/=10;
    }
    Console.WriteLine($"Третья цифра введенного вами числа: {N%10}");
    break;
}