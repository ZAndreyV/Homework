/* Задача 4: Напишите программу, которая принимает 
на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.Write("Введите первое целое число: ");
int firstnumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int secondnumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье целое число: ");
int thirdnumber = Convert.ToInt32(Console.ReadLine());
int max = firstnumber;
if (secondnumber > max) max = secondnumber;
if (thirdnumber > max) max = thirdnumber;
Console.WriteLine($"max = {max}");

