// Задача 60. Сформируйте трёхмерный массив из двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

//Ввод данных
int[] ReadInt(string text)
{
    System.Console.Write(text);
    return Array.ConvertAll(Console.ReadLine()!.Split(","), int.Parse); ;
}

//Генерация 3D матрицы
int[,,] FillMatrix3D(int row, int col, int deep, int min, int max)
{
    int[,,] matrix = new int[row, col, deep];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = rand.Next(min, max + 1);
            }
        }
    }
    return matrix;
}

//Печать элементов матрицы
void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.WriteLine($"{matrix[i, j, k]}({i},{j},{k})");
            }
        }
    }
}

bool ValidRange(int min, int max)
{
    if (min < 10 || min > 99 || max < 10 || max > 99)
    {
        return false;
    }
    else
        return true;
}

//...................................................
int[] range = ReadInt("Задайте мин. и макс. значения массива через запятую:  ");

if (ValidRange(range[0], range[1]))
{
    int[,,] matrix3D = FillMatrix3D(2, 2, 2, range[0], range[1]);
    PrintMatrix(matrix3D);
}
else
{
    Console.WriteLine("Матрица должна быть задана двузначными числами!");
}