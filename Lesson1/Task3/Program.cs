System.Console.WriteLine("Введите число, чтобы узнать чётное ли оно: ");
string A = Console.ReadLine() ?? "";
int A_int = Convert.ToInt32(A);
if (A_int % 2 == 0)
{
    System.Console.WriteLine("Y");
}
else
{
    System.Console.WriteLine("N");
}