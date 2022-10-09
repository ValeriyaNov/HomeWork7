// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
//в двумерном массиве, и возвращает значение этого элемента или же указание, 
//что такого элемента нет.  Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

using static System.Console;
Clear();
Write("Введите через пробел количество строк, количество столбцов, максимальное и минимальное значение элемента масссива: ");

string[]Str=ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
double[,] matrix1 = FullRealNumber(int.Parse(Str[0]), int.Parse(Str[1]), int.Parse(Str[2]), int.Parse(Str[3]));
PrintMatrix(matrix1);
ReturnElement(matrix1);


double[,] FullRealNumber (int row, int col, int min, int max)
{
   double[,] result= new double [row, col];

   for (int i=0; i<result.GetLength(0); i++) 
   {
    for (int j=0; j<result.GetLength(1); j++)
    
    result[i,j]=new Random().Next(min, max+1) + new Random().NextDouble();

   }
   return result;
}

void PrintMatrix (double[,] matrix)
{
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
        {
            Write($"{Math.Round(matrix[i,j],2)} \t");
        }
        WriteLine();
    }
}

void ReturnElement(double[,] array)
{
    do
    {
    Write("Введите стоку и столбец ячейки элемента массива через пробел: ");
    string[]String=ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int m = Convert.ToInt32(String[0]);
    int n = Convert.ToInt32(String[1]);
    if (m>=array.GetLength(0) | n>=array.GetLength(1)) 
    {WriteLine("Данной позиции нет в массиве"); }
    else
    {for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            if(i==m && j==n)
            WriteLine($"Элемент А[{m};{n}]={Math.Round(array[i,j],2)}");
    
        }
    }}
    WriteLine("Желаете продолжить? Если да - enter, нет - любая другая клавиша");
    }
    while(ReadKey().Key==ConsoleKey.Enter);
}

