//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Write("Введите число строк 1 матрицы:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов 1 матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов 2 матрицы: ");
int l = Convert.ToInt32(Console.ReadLine());

int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");
int[,] firstMatrix = new int[m, n];

CreateArray(firstMatrix);
Console.WriteLine($"\nМатрица 1:");
WriteArray(firstMatrix);


int[,] secondMatrix = new int[n, l];
CreateArray(secondMatrix);
Console.WriteLine($"\nМатрица 2:");
WriteArray(secondMatrix);

int[,] resultMatrix = new int[m, l];

MultiplyMatrix(firstMatrix, secondMatrix, resultMatrix);
Console.WriteLine($"\nПроизведение матриц:");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                sum += firstMatrix[i, k] * secondMatrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

void WriteArray(int[,] array)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
   
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

