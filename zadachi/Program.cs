Console.Write("Введите количество строк массива: \t");
int rows =Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: \t");
int columns =Convert.ToInt32(Console.ReadLine());

// Задача 48. Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: 
// Aₙₙ = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,]  GetArraySumOfSize(int rows, int columns) // для 48 задачи
{
    int[,] array = new int [rows, columns];

    Console.WriteLine($"\nЭтот массив, где каждый элемент соответствует формуле (строка + столбец):\n");
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = i + j;
            Console.Write($"{array[i, j]}");
        }
        Console.WriteLine();
     }
     return array;
}
GetArraySumOfSize(rows, columns);


// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1


Console.WriteLine();

int[,] GetArrayRandom (int rows, int columns, int MinValue = 1, int MaxValue = 10) 
// для задач 46, 49, 51
{
    int[,] array = new int[rows, columns];

    Console.WriteLine($"Массив со случайными элементами от {MinValue} до {MaxValue - 1}:\n");

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(MinValue, MaxValue);
            Console.Write($"{array[i, j]}");
        }
        Console.WriteLine(); 
    }
    return array;         
}
int[,] arrayRandom = GetArrayRandom(rows, columns);


// Задача 49: Задайте двумерный массив. Найдите элементы, у которых
// оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4


void ReplacingArrayForSquares (int[,] array)
{
    Console.WriteLine($"\nВторой массив, в котором элементы с обоими чётными индексами заменены на их квадраты:\n");
    
    int[,] arrayReplace = new int[array.GetLength(0), array.GetLength(1)];

    for (int i = 0; i < arrayReplace.GetLength(0); i++)
    {
        for (int j = 0; j < arrayReplace.GetLength(1); j++)
        {
            arrayReplace[i,j] = array[i,j];
            if ((i % 2 == 0) && (j % 2 == 0)) arrayReplace[i,j] *= arrayReplace[i,j];
            Console.Write($"{arrayReplace[i, j]} ");
        }
        Console.WriteLine();
    }
}

ReplacingArrayForSquares(arrayRandom);

// Задача 51: Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int SumArrayDiagonal(int[,] array) // Task 51
{
    int sumDiagonal = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j) sumDiagonal += array[i, j];
        }
    }
    return sumDiagonal;
}

Console.WriteLine($"\nВо втором массиве сумма элементов по диагонали равна {SumArrayDiagonal(arrayRandom)}\n");








