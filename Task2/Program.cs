/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.

* Например, задан массив:

* 1 4 7 2

* 5 9 2 3

* 8 4 2 4

* 17 -> такого числа в массиве нет*/

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
            matr[i,j] = new Random().Next(1,1000)/10;
        }
    }
}




int[,] matrix = new int[4, 4];
FillArray(matrix);
System.Console.WriteLine();
PrintArrai(matrix);
System.Console.WriteLine();
int m = GetNumberByUser("введите номер столбца: " );
int n = GetNumberByUser("введите номер строки: " );

if (n > matrix.GetLength(0) || m > matrix.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {m} столбца и {n} строки равно {matrix[m-1,n-1]}");
}

