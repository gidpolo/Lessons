System.Console.WriteLine("Введите трехзначное число, чтобы узнать вторую цифру этого числа: ");
string N = Console.ReadLine() ?? "";
int N_int = Convert.ToInt32(N);
int i=0;
while (true)
{

do
{
    N_int %= 10;
    i++;
} while (N_int!=0);
 if (i>3 || i<3)
    {
        System.Console.WriteLine("Вы ввели не трехзначное число");
        break;
    }

}
// Ушёл в дебри, закончу позже