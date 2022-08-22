// Задача два : принимает на вход три числа и выдаёт максимальное из этих чисел
Console.Write("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье целое число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int big = num1;
if (num1 < num2)
{
    big = num2;
}
if (big < num3)
{
    big = num3;
}
Console.WriteLine("Наибольшее число: "+big);
