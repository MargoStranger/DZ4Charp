//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11                          452%10=2 , sum = sum + x(2), num = num/10 (45)
//                                   45%10=5 ,  sum = sum + x(5), num/10(4)
//                                   4%10=4 ,  sum = sum + x(4), num/10(0)
//82 -> 10
//9012 -> 12

//Решала через мат метод

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()!);

Console.Write($"Сумма числа {number} = {GetSum(number)} ");

int GetSum(int num)
{
    int sum = 0, x = 0;

    while (num > 0)
    {
        x = num % 10;           
        sum = sum + x;
        num = num / 10;
    }
    return sum;
}