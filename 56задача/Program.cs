// Задача 56: Задайте двумерный массив. Напишите метод, который будет находить строку 
// с наименьшей суммой элементов.

Console.WriteLine("Введите m - ");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите n - ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

int[,] array = Create2DArray(m, n);
Print2DArray(array);
Console.WriteLine();
int [] result = FindSumElements(array);
PrintArray(result);
Console.WriteLine();
int min = FindIndex(result);
Console.WriteLine($"{min + 1} строкa с наименьшей суммой элементов.");


int[,] Create2DArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random random = new Random();
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 20);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int [] FindSumElements (int [,] array)
{
    int [] result = new int [array.GetLength(0)];
    for (var i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (var j = 0; j < array.GetLength(1); j++)
        {
            sum+= array[i, j];
        }
       result[i] = sum;
    }
    return result;
}

int FindIndex (int [] array)
{
    int min = array[0];
    int index = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if(min > array[i])
        {
            min = array[i];
            index = i;
        }
    }
    return index;
}

void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array [i]} ");
    }
}
