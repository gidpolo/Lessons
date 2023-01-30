int UserRead()
{
    string N = Console.ReadLine() ?? "";
    int N_int = Convert.ToInt32(N);
    return N_int;
}

int[] Coords = new int[6];
string[] NamesOfCoords = {"A(X)","A(Y)","A(Z)","B(X)","B(Y)","B(Z)"};
Console.WriteLine("Введите последовательно координаты X,Y,Z точек A и B, для того чтобы узнать расстояние между ними в 3D пространстве:");
for (int i = 0, j = 0; i < 6 && j < 6; i++, j++)
{
    Console.WriteLine($"Введите координату {NamesOfCoords[j]}: ");
    int N = UserRead();
    Coords[i] = N;
}
double CoordX = Coords[3] - Coords[0];
double CoordY = Coords[4]- Coords[1];
double CoordZ = Coords[5] - Coords[2];
// double b = (3*3 + 2*2)+(6*6 + 1*1) + (8*8 + (-7)*(-7));
double n = (Math.Sqrt(Math.Pow(CoordX,2) + Math.Pow(CoordY,2) + Math.Pow(CoordZ,2)));
string result = string.Format("{0:f2}",n);
Console.WriteLine(result);
