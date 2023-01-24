System.Console.WriteLine("Введите трехзначное число, чтобы узнать вторую цифру этого числа: ");

static string UserRead()
{
   string N = Console.ReadLine() ?? "";
   return N;
}
int i = 0;
int i1 = 10;
string[] a = Array.Empty<string>();
do
{
    string N = UserRead();
    while (true)
    {
       int N1 = N %= i1;
       a[0+i] = a[0+i] + N;
       i++;
       i1+=10;
       if (N1 == null) 
       int N2 = a.Length;
       if (N2 > 3 || N2 < 3)
       {
        System.Console.WriteLine("Вы ввели не трёхзначное число, попробуйте снова: ");
        continue;
       }
       else
       {
        break;
       }
    }
    break;
} while (true);
    
// Ушёл в дебри, закончу позже