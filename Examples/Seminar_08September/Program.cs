// int[,] CreateRandom2Array(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, columns];

//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < columns; j++)
//         {
//             newArray[i,j] = new Random().Next(minValue, maxValue + 1);   
//         }
//     }
    
//     return newArray;
// }

// void ShowArray2(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");
        
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("Input number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of colums: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input the min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input the max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] newArray = CreateRandom2Array(m, n, min, max);
// ShowArray2(newArray);

/*
//Task 1. Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.
int[,] CreateRandom2Array(int rows, int columns)
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = i + j;   
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
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colums: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreateRandom2Array(m, n);
ShowArray2(newArray);
*/

/*
//Task 2. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
int[,] CreateRandom2Array(int rows, int columns, int minValue, int maxValue)
{
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
}

void SwitchQuad (int[,] array){
    
    for(int i = 0; i < array.GetLength(0); i += 2)
    {
        for(int j = 0; j < array.GetLength(1); j += 2)
           array[i,j] = array[i,j] * array[i,j];
    }
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colums: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreateRandom2Array(m, n, min, max);
ShowArray2(newArray);
Console.WriteLine();
SwitchQuad(newArray);
ShowArray2(newArray);
*/

/*
//Task 3. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
int[,] CreateRandom2Array(int rows, int columns, int minValue, int maxValue)
{
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
}

int FindSum (int[,] array){
    int sum = 0; 
    for(int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
        sum += array[i,i];    

    return sum;
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colums: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreateRandom2Array(m, n, min, max);
ShowArray2(newArray);
Console.WriteLine();
int sum = FindSum(newArray);
Console.WriteLine($"Сумма элементов на главной диагонали равна: {sum}");
*/