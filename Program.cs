// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

/*
int[,] Create2dArray(int rows, int cols, int min, int max)
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void Dif2dArray(int[,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp; 
                }
            }
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Enter numb of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter numb of cols: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter numb of min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter numb of max: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] array = Create2dArray(m, n, min, max);
Show2dArray(array);
System.Console.WriteLine();
Dif2dArray(array);
Console.WriteLine();
PrintArray(array);
*/


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

/*
int[,] Create2dArray(int rows, int cols, int min, int max)
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void Dif2dArray(int[,] array){
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        minRow += array[i,0];
    }
        for (int i = 0; i < array.GetLength(1); i++){
        
            
        for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
        if (sumRow > minRow) 
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;

        }
        
        {
            
        }
        Console.Write($"{minSumRow + 1} строка");
    }
    


Console.Write("Enter numb of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter numb of cols: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter numb of min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter numb of max: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] array = Create2dArray(m, n, min, max);
Show2dArray(array);
System.Console.WriteLine();
Dif2dArray(array);
Console.WriteLine();
*/


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

/*
int[,] CreateArray1(int rows, int cols, int min, int max)
{ 
    int[,] array1 = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array1[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array1;
}

void ShowArray1(int[,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            Console.Write(array1[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int[,] CreateArray2(int rows, int cols, int min, int max)
{
    int[,] array2 = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array2[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array2;
}

void ShowArray2(int[,] array2)
{
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            Console.Write(array2[i, j] + "  ");
        }
        Console.WriteLine();
    }
}
void PoztivMatrix (int[,] array1, int[,] array2){
if (array1.GetLength(0) != array2.GetLength(1))
    {
    Console.WriteLine(" Нельзя перемножить ");
    
    }
    else{ 
}
for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
       int result = 0;
        for (int k = 0; k < array1.GetLength(1); k++)
        {
            result += array1[i, k] * array2[k, j];
        }Console.WriteLine(result);
    }
}

}

Console.Write("Enter numb of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter numb of cols: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter numb of min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter numb of max: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] array1 = CreateArray1(m, n, min, max);
int[,] array2 = CreateArray2(m, n, min, max);
ShowArray1(array1);
Console.WriteLine();
ShowArray2(array2);
PoztivMatrix(array1, array2 );
Console.WriteLine();
*/


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

/*
int[,,] CreateArray()
{ 
    int count = 10;
    int[,,] array = new int[2,2,2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
             for (int k = 0; k < array.GetLength(2); k++){
                array[i, j, k] += count;
                count += 2;
            
             }
        }
    }
    return array;
}

void ShowArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            Console.Write($"{array[i, j, k]} ({i},{j},{k}) + {" "} " );
        }
        Console.WriteLine();
    }
}
CreateArray();
int[,,] array = CreateArray();
ShowArray(array);
*/


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

/*
int[,] Create2dArray(int rows, int cols)
{
    int count = 1;
    int[,] array = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = i; j < rows-i; j++) array[i,j] = count++;
        for(int k = i+1;k<cols-i;k++) array[k,cols-1-i]= count++;
        for(int j=rows-i-2; j>=i;j--) array[rows-1-i,j] = count++;
        for(int k=cols-2-i; k>i; k--) array[k,i] = count++;
       
    }
    return array;
}

void Show2dArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int rows = 4;
int cols = 4;
Console.WriteLine();
int[,] array = Create2dArray(rows, cols);
Show2dArray(array);
*/