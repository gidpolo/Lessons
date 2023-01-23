System.Console.WriteLine("Введите два числа: ");
string A = Console.ReadLine() ?? "";
string B = Console.ReadLine() ?? "";
int A_int = Convert.ToInt32(A);
int B_int = Convert.ToInt32(B);
if (A_int > B_int)
{
  System.Console.WriteLine($"Число {A} больше числа {B}");
}
else
{
    System.Console.WriteLine($"Число {B} больше числа {A}");
}