// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120

int M = 15;
int N = 1;

// System.Console.WriteLine("Введите значение числа N");  // Ввод числа N с консоли
// int N = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите значение числа M");  // Ввод числа M с консоли
// int M = Convert.ToInt32(Console.ReadLine());

int GetSumNatural(int start, int end)
{
    if (start > 0 && end > 0)
    {
        if (start == end)
        {
            return start;
        }
        if (start > end)
        {
            System.Console.WriteLine("В связи с тем, что N < M промежуток стал от N до M");
            return end + GetSumNatural(end + 1, start);
        }
        else
        {
            return start + GetSumNatural(start + 1, end);
        }
    }
    else
    {
        System.Console.WriteLine("Отрицательные числа а также ноль не являются натуральными.");
        System.Console.WriteLine($"M={M} N={N}");
        return 0;
    }
}

System.Console.WriteLine(GetSumNatural(M,N));