/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

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