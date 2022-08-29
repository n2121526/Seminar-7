/* Задача 50: Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание,
что такого элемента нет.*/

Console.Write("rows = ");
int rows = int.Parse(Console.ReadLine());
Console.Write("columns = ");
int columns = int.Parse(Console.ReadLine());

int[,] GetArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FindElement(int[,] array)
{
    Console.Write("Введите порядковый номер строки искомого элемента : ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Введите порядковый номер столбца искомого элемента : ");
    int b = int.Parse(Console.ReadLine());
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (a == i && b == j)
            {
                Console.WriteLine(array[i, j]);
            }
        }
    }
    if (a > array.GetLength(0) || b > array.GetLength(1))
    {
        Console.WriteLine("Такого элемента в массиве нет");
    }
    return;
}

int[,] array = GetArray(rows, columns);
PrintArray(array);
FindElement(array);
