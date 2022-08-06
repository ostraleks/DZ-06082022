/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/
Console.Write("введите число ");
int numberA = Convert.ToInt32(Console.ReadLine());
int evennumber = 1;
while (evennumber <= numberA)
{
    if (evennumber%2 != 1)
    {
        Console.Write(evennumber + " ");
    }
    evennumber++;
}
