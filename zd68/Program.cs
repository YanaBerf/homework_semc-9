﻿// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.Clear();
Console.Write("enter number M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("enter number N: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(Akkerman(m, n));
int Akkerman(int m, int n){
    if (n == 0) return Akkerman(m-1, 1);
    if (m == 0) return n + 1;
    return (Akkerman(m-1, Akkerman(m, n-1)));

}
