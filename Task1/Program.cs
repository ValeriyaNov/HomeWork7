// Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

using static System.Console;
Clear();
Write("Введите через пробел количество строк, количество столбцов, максимальное и минимальное значение элемента масссива: ");
string[]Str=ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
double[,] matrix1 = FullRealNumber(int.Parse(Str[0]), int.Parse(Str[1]), int.Parse(Str[2]), int.Parse(Str[3]));
PrintMatrix(matrix1);


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