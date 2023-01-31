System.Console.WriteLine("Введите трехзначное число, чтобы узнать вторую цифру этого числа: ");

int UserRead()
{
    string N = Console.ReadLine() ?? "";
    int N_int = Convert.ToInt32(N);
    return N_int;
}

while (true)
{
    int N = UserRead();
    if (N < 100 || N > 999)
    {
        System.Console.WriteLine("Вы ввели не трёхзначное число, попробуйте снова: ");
        continue;
    }

    N = N / 10 % 10;
    Console.WriteLine($"Вторая цифра введенного вами числа: {N}");
    break;
}