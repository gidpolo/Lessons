// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
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

Console.WriteLine("Введите пятизначное число, чтобы узнать является ли оно палидромом: ");

while (true)
{
    int N = UserRead();
    int N1 = N;
    int i = 0;
    while (N1 != 0)
    {
        N1 /= 10;
        i++;
    }

    if ((i > 5) || (i < 5))
    {
        Console.WriteLine("Вы ввели не пятизначное число, попробуйте снова: ");
        continue;
    }
    if (N == Check(N)) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
    break;
}