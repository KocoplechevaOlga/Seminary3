//  Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных 
// координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти: ");
Console.Write("Q: ");
int Q = Convert.ToInt32(Console.ReadLine());

string Range (int q)
{
    if (q == 1) return "x > 0 && y > 0";
    if (q == 2) return "x < 0 && y > 0";
    if (q == 3) return "x < 0 && y < 0";
    if (q == 4) return "x > 0 && y < 0";
    return "Введен некорректный номер четверти";
}

string xy = Range (Q);
Console.WriteLine(xy);