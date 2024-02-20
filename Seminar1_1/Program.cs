// Напишите программу, которая на вход принимает _x000b_целое число N, а на выходе
// показывает все целые _x000b_числа в промежутке от -N до N.

Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 0)
{
num = num*(- 1);
}
int index = - num;
while (index <= num)
{
Console.Write($"{index} ");
index++; // index++ => index = index + 1
// index--; => index = index - 1
// index += 2; => index = index + 2
}