﻿Console.WriteLine("Введите число M:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N:");
int n = int.Parse(Console.ReadLine());

int Akk(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if (n != 0 && m == 0)
        return Akk(n - 1, 1);
    else
        return Akk(n - 1, Akk(n, m - 1));
}

Console.WriteLine("Ответ:"+Akk(m, n));