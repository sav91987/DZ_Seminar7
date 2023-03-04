System.Console.WriteLine("Введите число строк двумерного массива: ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число столбцов двумерного массива: ");
int m = Convert.ToInt32(Console.ReadLine());

if (n<0 || m<0) System.Console.WriteLine("У двумерного массива должна быть хотя бы 1 строка или 1 столбец");
else 
{
double[,] resultMatrix = GetMatrix(n, m);
System.Console.WriteLine($"Массив вещественных чисел размера {n} на {m}");
PrintMatrix(resultMatrix);
}

double[,] GetMatrix(int rows, int cols)
{
    double[,] matrix = new double[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = Math.Round((new Random().NextDouble() - 0.5) * 100, 1);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matr)
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



