// Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицe квадратов чисел от 1 до N.

void TableSq (int n, int c) 
{
  if (n > 0)
  { 
  while (c <= n)
    {
    
    Console.WriteLine($"{c,4}   ->   {c*c,4}");
    c++;
    }
 }
 else 
 {
    Console.WriteLine($"Введите число больше 0");
 }
}

Console.WriteLine("Введите число:  ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;

TableSq(N, count);
