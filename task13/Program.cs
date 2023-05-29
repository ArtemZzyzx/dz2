/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Напишите число: ");
string stringNum = Console.ReadLine();
if(stringNum.Length < 3)
{
Console.WriteLine("В числе третьей цифры нет");
}
else
{
    Console.WriteLine("Третья цифра заданного числа "+stringNum[2]);
}