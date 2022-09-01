/*
//Task 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int MathPow(int num, int pow){
    int result = num;
    for (int i = 1; i < pow; i++){
        result = result * num;
        Console.WriteLine(result);
    }
    return result;
}

Console.Write("Введите натуральное целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень, в которую необходимо возвести это число: ");
int power = Convert.ToInt32(Console.ReadLine());

int result = MathPow(number, power);

Console.Write($"Число {number} в степени {power} равняется {result}.");
*/

/*
//Task 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int SplittingNumber(string num, int size){
    int digit;
    int sum = 0;
    int currentNum = Convert.ToInt32 (num);
    int j = 10;

    for (int i = 0; i < size; i++){
        digit = currentNum % 10;
        currentNum = Convert.ToInt32 (num) / j;
        sum += digit;
        j = j * 10; 
    }

    return sum;
}

Console.Write("Введите число: ");
string? number = Console.ReadLine();

int quantity = number.Length;

Console.Write($"Сумма цифр в числе {number} равна {SplittingNumber(number, quantity)}.");
*/

/*
//Task 3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
void ShowArray(int size){
    int[] arr = new int [size];

    for (int i = 0; i < size; i++){
        Console.Write($"Введите {i + 1}й элемент массива: ");
        int num = Convert.ToInt32(Console.ReadLine());
        arr[i] = num;
    }

    Console.Write($"Ваш массив: ");
    for (int i = 0; i < size; i++){
        Console.Write($"{arr[i]} ");
    }
}

Console.Write("Введите размер массива: ");
int sizeArr = Convert.ToInt32(Console.ReadLine());

ShowArray(sizeArr);
*/