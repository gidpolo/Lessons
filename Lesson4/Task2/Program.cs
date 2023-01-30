int UserRead()
{
    string N = Console.ReadLine() ?? "";
    int N_int = Convert.ToInt32(N);
    return N_int;
}
Console.WriteLine("Введите число, чтобы узнать сумму его цифр:");
int N = UserRead();
int N1 = 0;
while (N != 0)
{
    N1 += N%10;
    N /=10;
}
Console.WriteLine(N1);