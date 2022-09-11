/*
//Task 1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int CounterNum (int[] array){
    int counter = 0;
    for(int i = 0; i < array.Length; i++)
        if (array[i] > 0) counter++;

    return counter;
}

Console.Write("Введите количество вводимых чисел: ");
int size = Convert.ToInt32 (Console.ReadLine());
int[] arr = new int [size];
for (int i = 0; i < size; i++){
    Console.Write("Введите число: ");
    int num = Convert.ToInt32 (Console.ReadLine());
    arr[i] = num;
}
int result = CounterNum(arr);
Console.WriteLine($"\nСреди введенных чисел, больше нуля {result}");
*/

/*
//Task 1*. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int CounterNum (string num){
    int counter = 0;
    if (Convert.ToInt32 (num) > 0) counter++;

    return counter;
}

int result = 0;
Console.WriteLine("Чтобы завершить введите <stop>");

while (true){
Console.Write("Input number: ");
string? number = Console.ReadLine();
if (number == "stop"){
        Console.Write($"\nСреди введенных чисел, больше нуля {result}");
        System.Environment.Exit(0);
    } 
result += CounterNum(number);
}
*/

/*
//Task 2.  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
void FindDot(double k1, double k2, double b1, double b2){
    if ((k1 == k2) && (b1 == b2)) Console.WriteLine("Прямые совпадают");
    else if (k1 == k2) Console.WriteLine("Прямые параллельны");
    else{
        double x = (b2 - b1) / (k1 - k2);
        double y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
        //cout << "x=" << x << "y=" << y;
        Console.WriteLine($"x = {x} y = {y}");
    }
}

Console.Write("Input b1: ");
double b1 = Convert.ToDouble (Console.ReadLine());
Console.Write("Input k1: ");
double k1 = Convert.ToDouble (Console.ReadLine());
Console.Write("Input b2: ");
double b2 = Convert.ToDouble (Console.ReadLine());
Console.Write("Input k2: ");
double k2 = Convert.ToDouble (Console.ReadLine());

FindDot(k1, k2, b1, b2);
*/