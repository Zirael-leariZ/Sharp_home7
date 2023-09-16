// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int[,] FillMatrix(int row, int columns, int min, int max)
{
    Random rand = new Random();
    int[,] dbArray = new int[row, columns];
    for(int i = 0; i < row; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            dbArray[i, j] = rand.Next(min , max + 1);
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

List<double> Average(int[,] matrix)
{
    List<double> myList = new List<double>();
    int i = 0;
    int j = 0;
    double sum = 0;
    while(i < matrix.GetLength(0))
    {
        if (j < matrix.GetLength(1))
        {
            sum = sum + matrix[i,j];
            j++;
        }
        else
        {
            double average = sum / matrix.GetLength(1);
            myList.Add(average);
            i++;
            sum = 0;
            j = 0;
        }
    }
    return myList;
}

int[,] newMatrix = FillMatrix(4, 4, 1, 10);
PrintMatrix(newMatrix);
Console.WriteLine();
List<double> average = Average(newMatrix);
foreach(double num in average)
{
    Console.Write($"{num:F2} ");
}



