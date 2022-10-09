// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
//арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using static System.Console;
Clear();
Write("Введите через пробел количество строк, количество столбцов, максимальное и минимальное значения элемента масссива: ");

string[]Str=ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,] matrix1 = FullRealNumber(int.Parse(Str[0]), int.Parse(Str[1]), int.Parse(Str[2]), int.Parse(Str[3]));
PrintMatrix(matrix1);
WriteLine();
Sum (matrix1);



int[,] FullRealNumber (int row, int col, int min, int max)
{
   int[,] result= new int [row, col];

   for (int i=0; i<result.GetLength(0); i++) 
   {
    for (int j=0; j<result.GetLength(1); j++)
    
    result[i,j]=new Random().Next(min, max+1);

   }
   return result;
}

void PrintMatrix (int[,] matrix)
{
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
        {
            Write($"{matrix[i,j]} \t");
        }
        WriteLine();
    }
}

void Sum (int[,]array)
{
    int[,]array3= new int[array.GetLength(1), array.GetLength(0)];
    for(int i=0; i<array.GetLength(1); i++)
    { 
        for (int j=0; j<array.GetLength(0); j++)
        {
           array3[i,j]=array[j,i];
        }        
    }

    for(int i=0; i<array3.GetLength(0); i++)
    { 
        double sum=0;
        for (int j=0; j<array3.GetLength(1); j++)
        {
           sum=sum+array3[i,j];
        }
        double average = sum/array3.GetLength(1);
        WriteLine($"среднее арифметическое в {i+1} столбце = {Math.Round(average,3)};");        
    }
}