/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.WriteLine("Введите число: ");
string input = Console.ReadLine();
int length = input.Length;
if (length > 2)
{
    Console.WriteLine(input[2]);
}
else 
{
    Console.WriteLine("Третьей цифры нет");
}