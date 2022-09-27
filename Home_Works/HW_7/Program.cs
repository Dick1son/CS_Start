/*
//Task 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
double[,] CreateRandom2Array()
{
    Console.Write("Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of colums: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    double[,] newArray = new double[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
        }
    }
    
    return newArray;
}

void ShowArray2(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(Math.Round(array[i,j], 2) + " ");
        
        Console.WriteLine();
    }
    Console.WriteLine();
}

ShowArray2(CreateRandom2Array());
*/


//Task 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
string[,] CreateRandom2Array()
{
    Console.Write("Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of colums: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    string[,] newArray = new string[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = Convert.ToString(new Random().Next(minValue, maxValue + 1));   
        }
    }
    
    return newArray;
}

void ShowArray2(string[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
    Console.WriteLine();
}

string[,] FirstArray(string[,] array){
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    string[,] arr = new string [rows, columns];

    for (int i = 0; i < rows; i++){
        for (int j = 0; j < columns; j++){
            arr[i,j] = "?";
        }
    }

    return arr;
}

string[,] SwitchSelected(string[,] firstArray, string[,] createArray){
    int row = 0;
    int column = 0;
    bool verify = false;
    while(verify == false){
        Console.Write("Input the line number of the item you are looking for: ");
         row = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the column number of the item you are looking for: ");
         column = Convert.ToInt32(Console.ReadLine());
        if (row >= firstArray.GetLength(0) || column >= firstArray.GetLength(1)){
            Console.WriteLine("There is no element with such indexes\n");
            
        }else verify = true;
    }
    firstArray[row, column] = createArray[row, column];

    return firstArray;
}
string[,] createArray = CreateRandom2Array();
string[,] firstArray = FirstArray(createArray);

ShowArray2(firstArray);

while(true){
    ShowArray2(SwitchSelected(firstArray, createArray));
}


/*
//Task 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
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

double[] MidSum(int[,] array){
    double midSum;
    double sumElements;
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    double[] result = new double [rows];
    for(int j = 0; j < rows; j++){
        midSum = 0;
        sumElements = 0;
        for(int i = 0; i < columns; i++){
            sumElements += array[i,j];
        }
        midSum = Math.Round (sumElements / columns, 2);
        result[j] = midSum;
    }

    return result;
}

int[,] myArray = CreateRandom2Array();
ShowArray2(myArray);

Console.Write("Среднее арифметическое элементов в каждом столбце: ");
double[] result = MidSum(myArray);
for (int i = 0; i < myArray.GetLength(0); i++){
    Console.Write($"{result[i]} ") ;
}
*/