/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
 какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

Console.Write("Введите первое целое число: ");
int firstnumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int secondnumber = Convert.ToInt32(Console.ReadLine());
if (firstnumber>secondnumber)
{
    Console.WriteLine($"max = {firstnumber} min = {secondnumber}");
}
else
{
    Console.WriteLine($"max = {secondnumber} min = {firstnumber}");
}