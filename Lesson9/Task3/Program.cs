int Akk(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
        if ((n != 0) && (m == 0))
        return Akk(n - 1, 1);
    else
        return Akk(n - 1, Akk(n, m - 1));
}
int UserRead()
{
    string N = Console.ReadLine() ?? "";
    int N_int = Convert.ToInt32(N);
    return N_int;
}
int N = UserRead();
int M = UserRead();
Console.WriteLine(" ");
Console.WriteLine(Akk(N,M));