//Task 1. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,] CreateRandom2Array()
{
    Console.Write("Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of colums: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);   
        }
    }
    
    return newArray;
}

void ShowArray2(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SortedArray(int[,] array){
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int[] sortedRow = new int [columns];
    for (int i = 0; i < rows; i++){
        for (int j = 0; j < columns; j++){
            sortedRow[j] = array[i,j];
        }
        Array.Sort(sortedRow);
        Array.Reverse(sortedRow);
        for (int j = 0; j < columns; j++){
            array[i,j] = sortedRow[j];
        }
    }
}

int[,] myArr = CreateRandom2Array();

ShowArray2(myArr);

SortedArray(myArr);

ShowArray2(myArr);
*/

//Task 2. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[,] CreateRandom2Array()
{
    Console.Write("Input number of rows and columns (n x n): ");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] newArray = new int[size, size];

    for(int i = 0; i < size; i++)
    {
        for(int j = 0; j < size; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);   
        }
    }
    
    return newArray;
}

void ShowArray2(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
    Console.WriteLine();
}

int FindMinRow(int[,] array){
    int minRow = 0;
    int minSum = 0;
    int sum = 0;
        for(int j = 0; j < array.GetLength(1); j++){
            minSum += array[0,j];
        }
    for(int i = 0; i < array.GetLength(0); i++){
        sum = 0;
        for(int j = 0; j < array.GetLength(1); j++){
            sum += array[i,j];
        }
        if (minSum > sum){
            minSum = sum;
            minRow = i;
        }
    }

    return minRow;
}

int[,] myArray = CreateRandom2Array();
ShowArray2(myArray);

int minRow = FindMinRow(myArray);

Console.WriteLine($"Строка с наименьшей суммой элементов: {minRow + 1}");
*/

//Task 3. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*

int[,] CreateRandom2Array()
{
    Console.Write("Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of colums: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);   
        }
    }
    
    return newArray;
}

void ShowArray2(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MyltiplyArray(int [,] array1, int[,] array2){
    int rows, columns;
    if (array1.GetLength(0) > array2.GetLength(0)) rows = array1.GetLength(0);
    else rows = array2.GetLength(0);
    if (array1.GetLength(1) > array2.GetLength(1)) columns = array1.GetLength(1);
    else columns = array2.GetLength(1);
    int[,] result = new int [rows, columns];
    for (int i = 0; i < array1.GetLength(0); i++){
        for (int j = 0; j < array2.GetLength(1); j++){
            for (int n = 0; n < array2.GetLength(0); n++){
                result[i,j] += array1[i,n] * array2[n,j];
            }
        }
    }

    return result;
}

Console.WriteLine("Введите данные первой матрицы:");

int[,] myArr1 = CreateRandom2Array();

Console.WriteLine("Введите данные второй матрицы:");

int[,] myArr2 = CreateRandom2Array();

ShowArray2(myArr1);
ShowArray2(myArr2);

int[,] result = MyltiplyArray(myArr1, myArr2);

Console.WriteLine($"Произведение двух матриц равно: ");
ShowArray2(result);
*/

//Task 4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/* 
int[,,] CreateRandom3Array()
{
    Console.Write("Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of colums: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of page: ");
    int pages = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    if (maxValue < (rows * columns * pages)){
        Console.WriteLine("Error");
        System.Environment.Exit(0);
    }
    int size = rows * columns * pages;
    int[] newArray = new int[size];
    for (int i = 0; i < rows * columns * pages; i++){
        int j = new Random().Next(minValue, maxValue); // тут получаем случайное значение
        while (newArray.Contains(j)) j = new Random().Next(1, 20); // тут проверяем
        newArray[i] = j;
    }
    int[,,] arr3d = new int [rows, columns, pages];
    int counter = 0;

    for (int k = 0; k < pages; k++){
        for(int i = 0; i < rows; i++){
            for(int j = 0; j < columns; j++){
                arr3d[i,j,k] = newArray[counter];
                counter++;
            }
        }  
    } 

    return arr3d;
}

void ShowArray3(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++){
        for(int i = 0; i < array.GetLength(0); i++){
            for(int j = 0; j < array.GetLength(1); j++)
                if (array[i,j,k] < 10) Console.Write($" {array[i,j,k]}({k},{i},{j}) ");
                else Console.Write($"{array[i,j,k]}({k},{i},{j}) ");
        
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

ShowArray3(CreateRandom3Array());
 */

//Task 5. Напишите программу, которая заполнит спирально массив 4 на 4.(Я честно пытался сделать в общем виде, но она меня довела)
/* 
int[,] CreateRandom2Array()
{
    Console.Write("Input the start possible value: ");
    int startValue = Convert.ToInt32(Console.ReadLine());
    int size = 4;
    int[,] newArray = new int[size, size];
    int maxValue = startValue + size * size;

    for (int j = 0; j < size; j++) {
        newArray[0, j] = startValue;
        startValue++;
    }
    for (int i = 1; i < size; i++) {
        newArray[i, size - 1] = startValue;
        startValue++;
    }
    for (int j = size - 2; j >= 0; j--) {
        newArray[size- 1, j] = startValue;
        startValue++;
    }
    for (int i = size - 2; i > 0; i--) {
        newArray[i, 0] = startValue;
        startValue++;
    }

    for (int j = 1; j < size - 1; j++) {
        newArray[1, j] = startValue;
        startValue++;
    }
    for (int i = 1; i < size - 1; i++) {
        newArray[i, size - 2] = startValue - 1;
        startValue++;
    }
    for (int j = size - 2; j >= 1; j--) {
        newArray[size- 2, j] = startValue - 2;
        startValue++;
    }
    for (int i = size - 2; i > 1; i--) {
        newArray[i, 1] = startValue - 3;
        startValue++;
    }

    return newArray;
}

void ShowArray2(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            if (array[i,j] < 10) Console.Write("0" + array[i,j] + " ");
            else Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

ShowArray2(CreateRandom2Array());
 */