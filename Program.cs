/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9


Random random = new Random();
int m = 3;
int n = 4;
double[,] array = new double[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = random.NextDouble();
    }
}


for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
*/


/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> элемента с такими индексами в массиве нет


class Program
{
    static void Main(string[] args)
    {
        int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int m = 3;
        int n = 3;


        Console.Write("Enter the row position of the element: ");
        int row = int.Parse(Console.ReadLine());


        Console.Write("Enter the column position of the element: ");
        int col = int.Parse(Console.ReadLine());


        if (row < 0 || row >= m || col < 0 || col >= n)
        {
            Console.WriteLine("There is no such element in the array.");
        }
        else
        {
            Console.WriteLine("The value of the element is: " + array[row, col]);
        }


        Console.ReadLine();
    }
}
*/

/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int m, n;
Console.Write("Enter the number of rows: ");
m = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
n = int.Parse(Console.ReadLine());


int[,] array = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write("Enter the value for element at position [" + i + "," + j + "]: ");
        array[i, j] = int.Parse(Console.ReadLine());
    }
}
for (int col = 0; col < n; col++)
{
    double sum = 0;
    for (int row = 0; row < m; row++)
    {
        sum += array[row, col];
    }
    double mean = sum / m;
    Console.WriteLine("The mean of column " + (col + 1) + " is: " + mean);
}
*/