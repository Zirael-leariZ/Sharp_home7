// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int SetNumber(string input = " ")
{
    Console.WriteLine($"Choose the {input}");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

bool WhichPosition(int[,] sequence, int findRow, int findColumn)
{
    int numRows = sequence.GetLength(0);
    int numColumns = sequence.GetLength(1);
    if (findRow >= 0 && numRows > findRow && findColumn >= 0 && numColumns > findColumn)
    {
        return true;
    }
    return false;
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


int[,] newMatrix = FillMatrix(4, 4, 1, 10);

PrintMatrix(newMatrix);

int findRow = SetNumber("row position, you want to find: ") - 1;
int findColumn = SetNumber("column position, you want to find: ") - 1;

bool result = WhichPosition(newMatrix, findRow, findColumn);
Console.WriteLine(result ? (object)newMatrix[findRow, findColumn] : "There is no such position");

