// Задача четыре: на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int a = 1;
if (num1 < 0)
{
    a = -1;
}
int num = 2;
while (num <= num1*a)
{
if (num%2 == 0)
{
    Console.Write(num*a + ", ");
}
num = num + 1;
} 
