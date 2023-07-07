// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

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

//Умножение матриц
int[,] MultiMatrix(int[,] matrix1, int[,] matrix2)
{
    int size = matrix1.GetLength(0);
    var resultMatrix = new int[size, size];
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

///..............................................
int[,] matrix1 = { { 2,4 }, { 3, 2} };
int[,] matrix2 = { {3,4},{3,3}};

int[,] matrix = MultiMatrix(matrix1, matrix2);

PrintMatrix(matrix);

