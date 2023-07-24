// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.Write("enter number M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("enter number N: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма чисел от {m} до {n} равна {SumNumbers(m, n)}");
int SumNumbers(int start, int end){
    if(start == end) return start;
    return (start + SumNumbers(start + 1, end));
}