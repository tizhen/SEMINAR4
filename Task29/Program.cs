﻿/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19, 6, 1, 33  -> [1, 2, 5, 7, 19, 6, 1, 33]*/

int[] array = new int[8];
void RandomArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 100);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
RandomArray(array);

PrintArray(array);

/*int N = 8;
int[] myArray = new int[N];
for (int i = 0; i < N; i++)
{
    myArray[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < N; i++)
{
    Console.Write("{0} ", myArray[i]);
}*/