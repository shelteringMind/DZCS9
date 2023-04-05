//*/
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


