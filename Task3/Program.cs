/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/
Console.Clear();

int GetNumberByUser(string text)
{
    Console.Write(text + "  ");
    return int.Parse(Console.ReadLine());
}

void PrintArrai(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        System.Console.Write($"{matr[ i, j ]} ");
    }
System.Console.WriteLine();
}
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(-100, 100) / 10;
        }
    }
}





int m = GetNumberByUser("Введите колличество столбцов массива: " );
int n = GetNumberByUser("Введите колличество строк массива: " );
int [,] matrix = new int[m, n];
FillArray(matrix);
System.Console.WriteLine();
PrintArrai(matrix);
System.Console.WriteLine();


for (int j = 0; j < matrix.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum = (sum + matrix[i, j]);
    }
    sum = sum / n;

    Console.WriteLine ($"Среднее арифметическое столбца № {j} = {sum};");
}

