// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//Генерация массива

int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] tempMatrix = new int[row, col];
    var rand = new Random();
    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return tempMatrix;
}

//Ввод данных
int[] ReadInt(string text)
{
    System.Console.Write(text);
    return Array.ConvertAll(Console.ReadLine()!.Split(","), int.Parse); ;
}

//Печать массива
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

//Поиск номера строки с минимальной суммой элементов
int FindNumStr(int[,] matrix)
{
    int min = 0;
    int minIndx = 0;
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
            if (j == matrix.GetLength(1) - 1)
            {
                if (i == 0)
                {
                    min = sum;
                }
                if (sum <= min)
                {
                    min = sum;
                    minIndx = i;
                }
            }
        }
    }
    return minIndx + 1;
}


//...
int[] size = ReadInt("Задайте количество строк и столбцов через запятую: ");

int[] range = ReadInt("Задайте левую и правую границы массива через запятую:  ");

int[,] matrix = FillMatrix(size[0], size[1], range[0], range[1]);

PrintMatrix(matrix);

Console.WriteLine("");
Console.WriteLine($"Номер строки с минимальной суммой элементов равен {FindNumStr(matrix)} ");
