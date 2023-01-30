int UserRead()
{
    string N = Console.ReadLine() ?? "";
    int N_int = Convert.ToInt32(N);
    return N_int;
}
Console.WriteLine("Введите числа A и B, чтобы возвести A в степень B:");
Console.Write("A -> ");
int A = UserRead();
int A1 = A;
Console.Write("B -> ");
int[] array = new int[UserRead()];
int k = array.Length - 1;
while (k != 0)
{
    A*=A1;
    k--;
}
Console.WriteLine($"A^B = {A}");