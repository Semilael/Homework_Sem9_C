// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 6, 7, 8""
Console.Write("Введите первое число: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int n = int.Parse(Console.ReadLine());

if (m < n)
{
    Console.Write("Диапазон введенных чисел: ");
    for(int i = m; i <= n; i++)
    {
        Console.Write(i + " ");
    }
}
if (m > n)
{
    Console.Write("Диапазон введенных чисел: ");
    for (int i = m ; i >= n ; i--)
    {
        Console.Write(i + " ");
    } 
}
else
{
    Console.WriteLine("Вы ввели неверный диапазон. Попробуйте снова.");
}