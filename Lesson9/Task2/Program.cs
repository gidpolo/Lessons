int UserRead()
{
    string N = Console.ReadLine() ?? "";
    int N_int = Convert.ToInt32(N);
    return N_int;
}
int SearchNumbers(int M, int N, int sum)
{
    if (M > N)
    {
        return sum;
    }
    sum=SearchNumbers(M + 1, N, sum)+ M;
    return sum;
}
int M = UserRead();
int N = UserRead();
int sum = 0;
Console.WriteLine(" ");
Console.WriteLine(SearchNumbers(M, N, sum));
