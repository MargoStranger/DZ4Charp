//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Write("Введите первое число A: ");
double A = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите степень B: ");
double B = Convert.ToDouble(Console.ReadLine()!);

Console.Write($"Число A - {A} в степени B - {B} = {GetPow(A, B)} ");

//Функция возведения числа А в степень Б
double GetPow(double a, double b)
{
    double pow = Math.Pow(a, b);
    return pow;
}

