System.Console.WriteLine("Введите число соответствующее дню недели, чтобы узнать выходной ли этот день: ");

int UserRead()
{
    string N = Console.ReadLine() ?? "";
    int N_int = Convert.ToInt32(N);
    return N_int;
}

while (true)
{
    int N = UserRead();
    if (N == 0 || N > 7)
    {
        System.Console.WriteLine("Вы ввели цифру не соответствующую дню недели, попробуйте снова: ");
        continue;
    }
    switch (N)
    {
        case 1: Console.WriteLine ("Нет"); break;    
        case 2: Console.WriteLine ("Нет"); break; 
        case 3: Console.WriteLine ("Нет"); break; 
        case 4: Console.WriteLine ("Нет"); break; 
        case 5: Console.WriteLine ("Нет"); break; 
        case 6: Console.WriteLine ("Да"); break; 
        case 7: Console.WriteLine ("Да"); break;     
    }
    break;
}



