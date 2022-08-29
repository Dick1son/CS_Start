/*
//Task 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
int FindSum(int num){
    int sum = 0;

    for (int current = 1; current <= num; current++)
        sum += current;
    
    return sum;
}

Console.Write("Введите положительное целое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write($"Сумма от 1 до {a} равна {FindSum(a)}");
*/

/*
//Task 2. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
int SizeNumber(int num){
    int size = 0;
    while (num > 0){
        num = num / 10;
        size++;
    }

    return size;
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Size of number is {SizeNumber(number)}.");
*/

/*
//Task 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
int Factorial(int num){
    int result = 1;
    int i = 1;
    while (i <= num){
        result = result * i;
        i++;
    }

    return result;
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Произведение чисел от 1 до {number} равно {Factorial(number)}.");
*/

/*
//Task 4. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
int[] FillArray(int size, int minValue, int maxValue){
    int[] arr = new int [size];
    for (int i = 0; i < size; i++){
        arr[i] = new Random().Next(minValue, maxValue + 1);
        i++;
    }
    return arr;
}

void ShowArray(int [] arr){
    for (int i = 0; i < arr.Length; i++){
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

ShowArray(FillArray(8, 0, 1));
*/