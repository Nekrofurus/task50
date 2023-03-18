//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента
// или указание, что такого элемента нет.
int numberLine = UserInput("Количество строк в новой таблице = ");
int numberColumb = UserInput("Количество столбцов в новой таблице = ");
int maximum = UserInput("Введите максимальное значение = ");
int minimum = UserInput("Введите минимальное значение = ");
double[,] CreateRandomDoubleMatrix(int line, int columb, int min, int max)
{
    double[,] matrix = new double[line, columb];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < columb; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}
int UserInput(string massage)
{
    Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
double[,] createRandomDoubleMatrix = CreateRandomDoubleMatrix(numberLine, numberColumb, minimum, maximum);
void PrintArrayMatrix(double[,] matrix, int line, int columb)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
PrintArrayMatrix(createRandomDoubleMatrix, numberLine, numberColumb);
Console.Write("Для поиска значения элемента в массиве");
int findlinePos = UserInput("Введите номер строки =");
int findcolumbPos = UserInput("Введите номер столбца =");
void FindMeanMatrix(double[,] matrix, int line, int columb)
{
    if (line <= matrix.GetLength(0) && columb <= matrix.GetLength(1))
    {
        Console.WriteLine($"Значение искомого элемента {matrix[line - 1, columb - 1]}");
    }
    else
    {
        Console.Write("Такого элемента не существует");
    }
}
FindMeanMatrix(createRandomDoubleMatrix, findlinePos, findcolumbPos);