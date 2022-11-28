//Задача 54: Задайте двумерный массив. Напишите метод, который 
//упорядочит по убыванию элементы каждой строки двумерного массива.

// Console.WriteLine("Введите m - ");
// bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
// Console.WriteLine("Введите n - ");
// bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

// int[,] array = Create2DArray(m, n);
// Print2DArray(array);
// Console.WriteLine();

// SortElementsInDescendingOrder(array);
// PrintArray(array);


// int[,] Create2DArray(int m, int n)
// {
//     int[,] array = new int[m, n];
//     Random random = new Random();
//     for (var i = 0; i < array.GetLength(0); i++)
//     {
//         for (var j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = random.Next(10, 20);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (var i = 0; i < array.GetLength(0); i++)
//     {
//         for (var j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void SortElementsInDescendingOrder(int [,] array)
// {
//     for (int k = 0; k < array.GetLength(0); k++)
//     {
//         for (int i = 0; i < array.GetLength(1); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 int max = array[k, j];
//                 if (array[k, i] > max)
//                 {
//                     int temp = array[k, i];
//                     array[k, i] = array[k, j];
//                     array[k, j] = temp;
//                 }
//             }
//         }
//     }
// }
// void PrintArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write($"{array[i, j]} ");
//     }
//     Console.WriteLine();
//   }
// }