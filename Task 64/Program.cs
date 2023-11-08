// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

int N = 5;

// System.Console.WriteLine("Введите значение числа N");  // Ввод числа N с консоли
// int N = Convert.ToInt32(Console.ReadLine());

string PrintNumber(int num)
{
    if (num < 1)
    {
        return "Примечание: отрицательные числа и ноль не являются натуральными\n1";
    }
    else if (num == 1)
    {
        return num.ToString();
    }
    else
    {
        return num + " " + PrintNumber(num - 1);
    }
}

System.Console.Write(PrintNumber(N));