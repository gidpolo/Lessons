int a = new Random().Next(100, 999);
Console.WriteLine(a);
int a1 = a/100;
int a2 = a%10;
Console.WriteLine($"{a1}{a2}");
//по другому не смог (: