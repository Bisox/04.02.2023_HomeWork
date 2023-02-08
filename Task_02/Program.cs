//  Задача 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого числа в массиве нет
// 1, 2 -> 4


int InputPosition(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void CreateArray(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 11);
        }

    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");

        }
        Console.WriteLine();
    }
}

int PositionElement(int[,] array, int row, int col)
{
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            result = array[row-1, col-1];

        }

    }
    return result;
}

int[,] matrix = new int[3, 3];
CreateArray(matrix);
PrintArray(matrix);



int row = InputPosition("Введите номер строки: ");
int col = InputPosition("Введите номер колонки: ");
if (row < matrix.GetLength(0) && col < matrix.GetLength(1))
{
    int pos = PositionElement(matrix, row, col);
    Console.WriteLine($"Элемент находящийся на позиции [{row}; {col}]: [{pos}] ");
}
else
{
    Console.WriteLine($"[{row}; {col}] - такого числа в массиве нет");
}