// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите координаты первой точки: ");
Console.Write("X1= ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1= ");
double y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты первой точки: ");
Console.Write("X2= ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2= ");
double y2 = Convert.ToInt32(Console.ReadLine());

double GetDistance (double X1, double Y1, double X2, double Y2)
{
double d = Math.Round(Math.Sqrt((X1-X2)*(X1-X2)+(Y1-Y2)*(Y1-Y2)), 2, MidpointRounding.ToZero);
return d;
}

double result = GetDistance(x1, y1, x2, y2);
Console.WriteLine($"Расстояние между точками составляет {result}");

