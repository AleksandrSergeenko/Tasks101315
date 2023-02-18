/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

/* 
int num;
Console.Write("Введите трёхзначное число: ");
int.TryParse(Console.ReadLine()!, out num);

for (int i = 1; i < 5 && (num <= 100 | num > 999); i++)
{
    Console.Write(i + $" Это не трёхзначное число, введите ещё раз: ");
    num = Convert.ToInt32(Console.ReadLine()!);
}
num = num / 10 % 10;
Console.WriteLine($"Вторая цифра введённого числа: {num}"); 
*/


/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

/* int num;
Console.Write($"Ведите число: ");
int.TryParse(Console.ReadLine()!, out num);
if (num > 99 && num <= 999)
{
    int ThirdDigit = num%10;
    Console.WriteLine($"Третье число: {ThirdDigit}");
}
else
{
    Console.Write($"Третьей цифры нет");
}
//для цифр более 3-х значных не работает, пока не понял, как написать.
 */


/*
Задача 15: 
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

/* 
int num;
Console.Write($"Введите число от 1 до 7: ");
num = Convert.ToInt32(Console.ReadLine()!);

if (num >= 1 && num <= 7)
{
    if (num == 6 | num == 7) Console.WriteLine("Выходной день");
    else Console.WriteLine("Рабочий день");
}
else Console.WriteLine("Ведено неверное число"); 
*/