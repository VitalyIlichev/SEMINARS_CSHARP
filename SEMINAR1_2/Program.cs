//Напишите программу, которая принимает на вход трёхзначное целое число 
//и на выходе показывает сумму первой и последней цифры этого числа.

// Console.Write("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int num1 = num%10; // 123%10 -> 3; 123%100 -> 23
// int num2 = num/100;
// Console.Write($"Сумма {num1} и {num2} равна {num1 + num2}");

Console.Write("Введите трехзначное число: ");
string num = Console.ReadLine()!;
Console.WriteLine(Convert.ToInt32(Convert.ToString(num[0])) +
Convert.ToInt32(Convert.ToString(num[2])));