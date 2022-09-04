//  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите первое число: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int n = int.Parse(Console.ReadLine());

if (m < n)
{
    int sum = 0;
    for(int i = m; i <= n; i++)
    {
        sum += i;
    }
    Console.Write($"Сумма диапазона введенных чисел: {sum}");
}
else
{
    Console.WriteLine("Вы ввели неверный диапазон. Попробуйте снова.");
}