System.Console.WriteLine("Введите индекс строки двумерного массива: ");
int k = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите индекс столбца двумерного массива: ");
int l = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine();

int n = new Random().Next(2, 11);
int m = new Random().Next(2, 11);

int[,] matrix = GetMatrix(n, m, 0, 10);
PrintMatrix(matrix);

if (k >= n || l >= m || k < 0 || l < 0)
{
    System.Console.WriteLine($"Элемента массива с индексами ({k}, {l}) не существует");
}
else
{
    System.Console.WriteLine($"Элемент массива с индексами ({k}, {l}) равен: {matrix[k, l]}");
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

