//Задача 1: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//* m = 3, n = 4.

//* 0,5 7 -2 -0,2

//* 1 -3,3 8 -9,9

//* 8 7,8 -7,1 9


Console.Clear();

int GetNumberByUser(string text)
{
    Console.Write(text + "  ");
    return int.Parse(Console.ReadLine());
}

void PrintArrai(double[,] matr)
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

void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void Task()
{
int m = GetNumberByUser("Введите колличество столбцов массива: " );
int n = GetNumberByUser("Введите колличество строк массива: " );
double [,] matrix = new double[m, n];
FillArray(matrix);
System.Console.WriteLine();
PrintArrai(matrix);
}

Task();