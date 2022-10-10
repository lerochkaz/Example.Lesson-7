// for (int i = 1; i < 60; i++)
// {
//     Console.WriteLine($"f({i}) = {SlowFibonacci(i)}");
// }

// Нахождение чисел Фибоначи
// double SlowFibonacci(int n)
// {
//     if (n == 1 || n == 2)
//         return 1;
//     else
//         return SlowFibonacci(n - 1) + SlowFibonacci(n - 2);
// }


// double FastFibonacci(int n, int sum = 1, int previousSum = 0)
// {
//     if (n == 0)
//         return previousSum;
//     else
//         return FastFibonacci(n - 1, sum + previousSum, sum);
// }



// Задача 48.Задайте массив размером m и n. Каждый элемент массива находится по формуле Amn=m+n.
// int[,] RequestForNumbers()
// {
//     Console.Write("Введите число m: ");
//     int m = int.Parse(Console.ReadLine()!);
//     Console.Write("Введите число n: ");
//     int n = int.Parse(Console.ReadLine()!);
//     int[,] array = new int[m, n];
//     return array;
// }

// void FillArray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = i + j;
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] newArray = RequestForNumbers();
// FillArray(newArray);
// PrintArray(newArray);


// Задача 49. Задайте двумерный массив. Элементы с четными индексами заменить на их квадраты.
// int[,] RequestForNumbers()
// {
//     Console.Write("Введите число m: ");
//     int m = int.Parse(Console.ReadLine()!);
//     Console.Write("Введите число n: ");
//     int n = int.Parse(Console.ReadLine()!);
//     int[,] array = new int[m, n];
//     return array;
// }

// void FillArray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Random generator = new Random();
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = generator.Next(0, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }


// int[,] ReplaceArray(int[,] array)
// {
//     for (int i = 2; i < array.GetLength(0); i += 2)
//     {
//         for (int j = 2; j < array.GetLength(1); j += 2)
//         {
//             array[i, j] = (int)Math.Pow(array[i, j], 2);
//         }
//     }
//     Console.WriteLine();
//     return array;
// }

// int[,] newArray = RequestForNumbers();
// FillArray(newArray);
// PrintArray(newArray);
// int[,] Replacement = ReplaceArray(newArray);
// PrintArray(Replacement);

// Задача.Найти сумму элементов, находящихся на главной диагонали.

// int[,] RequestForNumbers()
// {
//     Console.Write("Введите число m: ");
//     int m = int.Parse(Console.ReadLine()!);
//     Console.Write("Введите число n: ");
//     int n = int.Parse(Console.ReadLine()!);
//     int[,] array = new int[m, n];
//     return array;
// }

// void FillArray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Random generator = new Random();
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = generator.Next(0, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }


// int SumOfElements(int[,] array)
// {
//     int minSize = 0;
//     int sum = 0;
//     if (array.GetLength(0) < array.GetLength(1)) minSize = array.GetLength(0);
//     else minSize = array.GetLength(1);
//     for (int index = 0; index < minSize; index++)
//     {
//         sum = sum + array[index, index];
//     }
//     return sum;
// }

// int[,] newArray = RequestForNumbers();
// FillArray(newArray);
// PrintArray(newArray);
// int sumElementsAlongDiagonal = SumOfElements(newArray);
// Console.WriteLine($"Сумма элементов, находящихся на главной диагонали = {sumElementsAlongDiagonal}");


// Задача. Перевести число из 10-ой системы счисления в двоичную.
// Console.Clear();

// Console.Write("Введите десятичное число: ");
// int decimalNumber = int.Parse(Console.ReadLine()!);
// Console.Write(DecToBin(decimalNumber));

// string DecToBin(int decNumber, string binNumber = "")
// {
//     if (decNumber / 2 > 0)
//     {
//         binNumber += (decNumber % 2).ToString();
//         return DecToBin(decNumber / 2, binNumber);
//     }
//     else
//     {
//         binNumber += decNumber.ToString();
//         char[] charArray = binNumber.ToCharArray();
//         Array.Reverse(charArray);
//         return new string(charArray);
//     }
// }
