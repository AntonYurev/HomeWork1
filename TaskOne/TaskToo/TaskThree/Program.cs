// Задача три : на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("Введите целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 % 2 == 0)
{
    Console.WriteLine("Это четное число");
}
else
{
    Console.WriteLine("Это нечетное число");
}
 