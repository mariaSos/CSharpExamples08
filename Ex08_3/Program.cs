// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

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

//Умножение матриц
int[,] MultiMatrix(int[,] matrix1, int[,] matrix2)
{
    // int size = matrix1.GetLength(0);
    int row = matrix1.GetLength(0);
    int col = matrix2.GetLength(1);

    var resultMatrix = new int[row, col];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return resultMatrix;
}
bool ValidMulti(int col1, int row2)
{
    if (col1 != row2)
    {
        return false;
    }
    else
        return true;
}

///..............................................
//int[,] matrix1 = { { 2,4 }, { 3, 2} };
//int[,] matrix2 = { {3,4},{3,3}};

int[] size1 = ReadInt("Введите размер первой матрицы через запятую: ");
int[] size2 = ReadInt("Введите размер второй матрицы через запятую: ");

if (ValidMulti(size1[1], size2[0]))
{
    int[] rang1 = ReadInt("Введите левую и правую границы первой матрицы через запятую: ");
    int[] rang2 = ReadInt("Введите левую и правую границы второй матрицы через запятую: ");
    //Генерация массива

    int[,] matrix1 = FillMatrix(size1[0], size1[1], rang1[0], rang1[1]);
    int[,] matrix2 = FillMatrix(size2[0], size2[1], rang2[0], rang2[1]);

    int[,] multiMatrix = MultiMatrix(matrix1, matrix2);
    
    PrintMatrix(multiMatrix);
}
else
{
    System.Console.WriteLine("Умножение заданных матриц не возможно!");
}