// Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(PrintNumbers(1, num));
string PrintNumbers(int start, int end)
{
    if (end == start) return end.ToString();
    return (end + ", " + PrintNumbers(start, end - 1));
}
/*Console.Write("enter number: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(PrintNumber(1, n));
string PrintNumber(int start, int end){
    if(start == end) return start.ToString();
    return (start + " " + PrintNumber(start + 1, n));
}*/
    

