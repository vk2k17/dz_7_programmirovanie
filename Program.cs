// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


// using System;

// class Program
// {
//     static void Main()
//     {
//         // Размерность массива m × n
//         int m = 4;
//         int n = 5;

//         // Создание объекта для генерации сл. чисел
//         Random random = new Random();

//         // Создание двумерного массива и заполнение его сл. вещественными числами
//         double[,] array = new double[m, n];
//         for (int i = 0; i < m; i++)
//         {
//             for (int j = 0; j < n; j++)
//             {
//                 // Генерация сл. вещественного числа от 0 до 1
//                 array[i, j] = random.NextDouble();
//             }
//         }

//         Console.WriteLine("Сгенерированный двумерный массив:");
//         for (int i = 0; i < m; i++)
//         {
//             for (int j = 0; j < n; j++)
//             {
//                 Console.Write(array[i, j] + "\t");
//             }
//             Console.WriteLine();
//         }
//     }
// }



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.


// using System;

// class Program
// {
//     static void Main()
//     {
//         int[,] array = {
//             { 1, 2, 3 },
//             { 4, 5, 6 },
//             { 7, 8, 9 }
//         };

//         // Запрос позиции элемента у юзера
//         Console.Write("Введите номер строки (от 0 до 2): ");
//         int row = int.Parse(Console.ReadLine());

//         Console.Write("Введите номер столбца (от 0 до 2): ");
//         int column = int.Parse(Console.ReadLine());

//         if (row >= 0 && row < array.GetLength(0) && column >= 0 && column < array.GetLength(1))
//         {
//             int element = array[row, column];
//             Console.WriteLine($"Значение элемента на позиции [{row}, {column}]: {element}");
//         }
//         else
//         {
//             Console.WriteLine("Указанные позиции элемента недопустимы. Элемент не найден.");
//         }
//     }
// }


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// using System;

// class Program
// {
//     static void Main()
//     {
//         int[,] array = {
//             { 1, 2, 3 },
//             { 4, 5, 6 },
//             { 7, 8, 9 }
//         };

//         int rows = array.GetLength(0);
//         int columns = array.GetLength(1);

//         double[] columnAverages = new double[columns];

//          for (int j = 0; j < columns; j++) 
//         {
//             int sum = 0;
//             for (int i = 0; i < rows; i++)
//             {
//                 sum += array[i, j];
//             }
//             columnAverages[j] = (double)sum / rows;
//         }

//         Console.WriteLine("Средние арифметические значения для каждого столбца:");
//         for (int j = 0; j < columns; j++)
//         {
//             Console.WriteLine($"Столбец {j + 1}: {columnAverages[j]}");
//         }
//     }
// }

