// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

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

//Ввод данных
int[] ReadInt(string text)
{
    System.Console.Write(text);
    return Array.ConvertAll(Console.ReadLine()!.Split(","), int.Parse); ;
}

//Формирование массива по спирали
int[,] HelixMatrix(int row, int col)
{
    int[,] matrix = new int[row,col];
    int number = 1; //Первый элемент
    int sqr = 0; //Первый квадрат
    int countElemеnt = row * col;
    while (number <= countElemеnt)
    {
        //Строка вперед
        for (int i = sqr; i < matrix.GetLength(1) - sqr; i++)
        {
            if (matrix[sqr, i] == 0)
            {
                matrix[sqr, i] = number++;
            }
        }

        //Столбец вниз
        for (int i = sqr; i < matrix.GetLength(0) - sqr; i++)
        {
            if (matrix[i, matrix.GetLength(1) - 1 - sqr] == 0)
            {
                matrix[i, matrix.GetLength(1) - 1 - sqr] = number++;
            }
        }

        //Строка назад
        for (int i = matrix.GetLength(1) - 1 - sqr; i >= sqr; i--)
        {
            if (matrix[matrix.GetLength(0) - 1 - sqr, i] == 0)
            {
                matrix[matrix.GetLength(0) - 1 - sqr, i] = number++;
            }
        }

        //Столбец вверх
        for (int i = matrix.GetLength(0) - 1 - sqr; i >= sqr; i--)
        {
            if (matrix[i, sqr] == 0)
            {
                matrix[i, sqr] = number++;
            }
        }
        sqr++;
    }
    return matrix;
}
//........................................................................
int[] size = ReadInt("Задайте количество строк и столбцов через запятую: ");

int[,] matrix = HelixMatrix(size[0],size[1]);

PrintMatrix(matrix);


