System.Console.WriteLine("Введите число строк двумерного массива: ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число столбцов двумерного массива: ");
int m = Convert.ToInt32(Console.ReadLine());

if (n < 0 || m < 0) System.Console.WriteLine("У двумерного массива должна быть хотя бы 1 строка или 1 столбец");
else
{
    int[,] matrix = GetMatrix(n, m, 0, 10);
    System.Console.WriteLine();

    PrintMatrix(matrix);
    System.Console.WriteLine();

    GetAverageInCols(matrix);
}

int[,] GetMatrix(int rows, int cols, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return matrix;
}

void GetAverageInCols(int[,] inputMatrix)
{
    double count = inputMatrix.GetLength(1);
    for (int i = 0; i < inputMatrix.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < inputMatrix.GetLength(0); j++)
        {
            {
                sum += inputMatrix[j, i];
            }
        }
        double average = Math.Round((sum / count), 2);
        System.Console.WriteLine($"Среднее арифметическое чисел {i + 1}-го столбца равно {average}");
    }
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}