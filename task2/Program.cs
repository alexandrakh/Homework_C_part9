// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int m = 1, n = 15;
System.Console.WriteLine(Real(m, n));
int Real(int m, int n)
{
    int a = -1;
    if (m > n) a = 1;

    if (n == m)
        return n;
    return Real(m, n + a) + n;
}
