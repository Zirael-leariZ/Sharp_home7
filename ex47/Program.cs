// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5  7   -2 -0,2
//  1 -3,3   8 -9,9
//  8  7,8 -7,1  9


int SetNumber(string input = " ")
{
    Console.WriteLine($"Choose the {input}");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int[,] FillMatrix(int row, int columns, int min, int max)
{
    Random rand = new Random();
    int[,] dbArray = new int[row,columns];
    for(int i = 0; i < row; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            dbArray[i , j] = rand.Next(min , max + 1);
        }
    }
    return dbArray;
}

static void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 4}");
        }
        Console.WriteLine();
    } 
}

int row = SetNumber("row");
int columns = SetNumber("columns");
int minValue = SetNumber("minValue");
int maxValue = SetNumber("maxValue");

int[,] newMatrix = FillMatrix(row, columns, minValue, maxValue);

PrintMatrix(newMatrix);