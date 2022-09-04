/*
//Task 1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int FillShowArray(int size){
    int quantity = 0;
    int[] arr = new int [size];
    for (int i = 0; i < size; i++){
        arr[i] = new Random().Next(100, 1000);
    }
    Console.WriteLine();
    Console.Write($"Массив: ");
    for (int i = 0; i < size; i++){
      Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
    for (int i = 0; i < size; i++){
        if (arr[i] % 2 == 0) quantity++;
    }

    return quantity;
}

Console.Write("Введите размер массива: ");
int sizeArr = Convert.ToInt32 (Console.ReadLine());

Console.Write($"Количество четных чисел в массиве {FillShowArray(sizeArr)} ");
*/

/*
//Task 2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] FillShowArray(int size, int minValue, int maxValue){
    int[] arr = new int [size];
    for (int i = 0; i < size; i++){
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    Console.WriteLine();
    Console.Write($"Массив: ");
    for (int i = 0; i < size; i++){
      Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
    return arr;
}

int SumOdd(int[] arr){
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2){
        sum += arr[i];
    }

    return sum;
}

Console.Write("Введите размер массива: ");
int sizeArr = Convert.ToInt32 (Console.ReadLine());

Console.Write("Введите минимальный элемент массива: ");
int min = Convert.ToInt32 (Console.ReadLine());

Console.Write("Введите максимальный элемент массива: ");
int max = Convert.ToInt32 (Console.ReadLine());

int result = SumOdd(FillShowArray(sizeArr, min, max));

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {result}");
*/

/*
//Task 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] FillShowArray(int size, int minValue, int maxValue){
    double[] arr = new double [size];
    //int[] intArr = new int [size];
    for (int i = 0; i < size; i++){
        arr[i] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
    }
    Console.WriteLine();
    Console.Write($"Массив: ");
    for (int i = 0; i < size; i++){
      Console.Write($"| {Math.Round(arr[i], 2)} ");
      if (i == size - 1) Console.Write("|");
    }
    Console.WriteLine();
    return arr;
}

double FindDifference(double[] arr){
    double min = arr[0];
    double max = arr[0];
    double result;
    for (int i = 0; i < arr.Length; i++){
        if (min > arr[i]) min = arr[i];
        if (max < arr[i]) max = arr[i];
    }
    result = max - min;

    return result;
}

Console.Write("Введите размер массива: ");
int sizeArr = Convert.ToInt32 (Console.ReadLine());

Console.Write("Введите минимальный элемент массива: ");
int min = Convert.ToInt32 (Console.ReadLine());

Console.Write("Введите максимальный элемент массива: ");
int max = Convert.ToInt32 (Console.ReadLine());

double result = Math.Round (FindDifference(FillShowArray(sizeArr, min, max)), 2);

Console.WriteLine($"Разницу между максимальным и минимальным элементами массива равна {result}");
*/