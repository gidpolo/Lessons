int UserRead()
{
    string N = Console.ReadLine() ?? "";
    int N_int = Convert.ToInt32(N);
    return N_int;
}

void SearchNumbers(int M, int N)
{
    if (M > N)
    {
        return;
    }
    if (M % 2 == 0)
    {
        Console.Write(M + " ");
    }
    SearchNumbers(M + 1, N);
}
int M = UserRead();
int N = UserRead();
Console.WriteLine(" ");
SearchNumbers(M, N);
