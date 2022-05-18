/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
 является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
Console.WriteLine("Введите число: ");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);
if (number <= 5)
{
    Console.WriteLine("нет");
}

else
{
    Console.WriteLine("да");
}