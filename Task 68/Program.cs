// Задача 68: Напишите программу вычисления функции Аккермана
//  с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AKK(int num1,int num2) {
    if (num1 >= 0 && num2 >= 0)
    {
        if (num1 == 0)
        {
            return num2 + 1;
        }
        else if (num2 == 0)
        {
            return AKK(num1 - 1, 1);
        }
        else
        {
            return AKK(num1 - 1, AKK(num1, num2 - 1));
        }
    }
    else
    {
        System.Console.WriteLine("Требуются положительные значения, либо 0");
        return 0;
    }
}
int m = 2;
int n = 3;

System.Console.WriteLine(AKK(m,n));