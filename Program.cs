using FigureTest;

Console.WriteLine("Type arguement or 3 (press enter twice if one)");
double arg1,arg2,arg3;
double.TryParse(Console.ReadLine(), out arg1);
double.TryParse(Console.ReadLine(), out arg2);
double.TryParse(Console.ReadLine(), out arg3);
SquareFinder q = new SquareFinder();
double w = q.FindSquare(arg1, arg2, arg3);
Console.WriteLine(w);
