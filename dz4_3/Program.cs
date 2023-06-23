//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (можно указать любой промежуток)
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int[] GetArray(int size)
{
    int[] rezult = new int[size];
    for (int i=0; i < size; i++)
    {
        rezult[i]= new Random().Next(0,100);
    }
    return rezult;
}

int[] array = GetArray(8);
Console.Writeline($"[{String.Join(", ", array)}]");