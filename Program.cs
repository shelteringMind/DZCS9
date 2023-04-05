/*/
// Задача 64: **Выполнить с помощью рекурсии**.Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

string Recurs(int stop, int num)
{
    if(num == stop) return num.ToString();
    return (num + ", " + Recurs(stop, num - 1));
}

Console.WriteLine($"N = {N} -> \"{Recurs(1, N)}\"");
//*/

//*/
// Задача 66: **Выполнить с помощью рекурсии**.Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите первое число диапазона: ");
int M = int.Parse(Console.ReadLine()!);

Console.Write("Введите последнее число диапазона: ");
int N = int.Parse(Console.ReadLine()!);

int SumNumRecurs(int start, int stop)
{
    if(start == stop) return start;
    return (start += SumNumRecurs(start + 1, stop));
}

if(M > 0 && N > 0) Console.WriteLine($"M = {M}; N = {N} -> {SumNumRecurs(M, N)}");
else Console.Write("Вводимые Вами числа должны быть натуральными! Попробуйте еще раз... ");
//*/


