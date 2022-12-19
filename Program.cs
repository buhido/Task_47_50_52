// See https://aka.ms/new-console-template for more information
using System;
using System.Drawing;

Console.WriteLine("Hello, World!");


bool isWork = true;

while (isWork)
{
    string command = Console.ReadLine();

    switch (command)
    {
        case "task47": Task47(); break;
        case "task50": Task50(); break;
        case "task52": Task52(); break;
        case "exit": isWork = false; break;
    }
}


void Task47()
{
    // Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
    //m = 3, n = 4.
    //0,5 7 - 2 - 0,2

    //String.Empty
    void PrintArray(double[,] tab)
    {
        for (int i = 0; i < tab.GetLength(0); i++)
        {
            for (int j = 0; j < tab.GetLength(1); j++)
            {
                Console.Write($"{tab[i, j]} ");
            }
            Console.WriteLine();
        }
    }


    void FillArray(double[,] tab)  //Заполняющий таблицу массив               
    {
        for (double i = 0; i < tab.GetLength(0); i++)
        {
            for (double j = 0; j < tab.GetLength(1); j++)
            {
                tab[(int)i, (int)j] = new Random().NextDouble() * 100;
            }
        } 
    }

    double[,] table = new double[3, 4];
    FillArray(table);
    Console.WriteLine();
    PrintArray(table);
}

void Task50()
{
    //Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
    // и возвращает значение этого элемента или же указание, что такого элемента нет.
    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // 17 -> такого числа в массиве нет

    Console.Write("Введите номер строки: ");
    int rows = Convert.ToInt32(Console.ReadLine()) - 1;
    Console.Write("Введите номер столбца: ");
    int columns = Convert.ToInt32(Console.ReadLine()) - 1;
    int n = 4;
    int m = 6;
    Random random = new Random();
    int[,] arr = new int[n, m];
    Console.WriteLine("Массив: ");
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(10, 99);
            Console.Write("{0} ", arr[i, j]);
        }
        Console.WriteLine();
    }
    if (rows < 0 | rows > arr.GetLength(0) - 1 | columns < 0 | columns > arr.GetLength(1) - 1)
    {
        Console.WriteLine("Элемент не существует  ");
    }
    else
    {
        Console.WriteLine("Значение элемента массива = {0}", arr[rows, columns]);
    }
    Console.ReadLine();

}


void Task52()
{
    // Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
    // в каждом столбце.
    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

    Random random = new Random();
    int[,] arr = new int[random.Next(3, 7), random.Next(4, 6)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(1, 9);
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("Среднее арифметическое столбцов:");
        for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i, j];
        }
        Console.Write($"{sum / arr.GetLength(0)} ");
    }
    Console.ReadLine();

}