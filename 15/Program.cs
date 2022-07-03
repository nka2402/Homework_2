/*
 Напишите программу, которая принимает на вход цифру,
  обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите порядковый номер дня недели.");
int number = int.Parse(Console.ReadLine());

if (number < 6) 
{ 
    Console.WriteLine("Этот день - не выходной.");
}
else if (number == 6 | number == 7)
{
    Console.WriteLine("Этот день - выходной.");
}
else
{
    Console.WriteLine("Под таким номером нет дня недели.");
}
