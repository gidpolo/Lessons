System.Console.WriteLine("Введите 3 числа, для нахождения максимального из них");
System.Console.WriteLine("Первое: ");

string A = Console.ReadLine() ?? "";

System.Console.WriteLine("Второе:");

string B = Console.ReadLine() ?? "";

System.Console.WriteLine("Третье:");

string C = Console.ReadLine() ?? "";

int A_int = Convert.ToInt32(A);
int B_int = Convert.ToInt32(B);
int C_int = Convert.ToInt32(C);

if (A_int > B_int && A_int > C_int)
{
    System.Console.WriteLine($"Число {A_int} самое большое");
}
else if (B_int > A_int && B_int > C_int)
{
    System.Console.WriteLine($"Число {B_int} самое большое");
}
else
{
    System.Console.WriteLine($"Число {C_int} самое большое");
}