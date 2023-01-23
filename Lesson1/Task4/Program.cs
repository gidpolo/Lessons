System.Console.WriteLine("Введите число, до которого будут выведены все чётные числа: ");
string N = Console.ReadLine() ?? "";
int N_int = Convert.ToInt32(N);

 if (N_int==0)
{
    System.Console.WriteLine("Вы ввели 0");
}

if (N_int == 1)
{
    System.Console.WriteLine("До 1 нет чётных чисел");
}

for (int i = 2; i <= N_int; i+=2)
{
    System.Console.Write($"{i} ");

}