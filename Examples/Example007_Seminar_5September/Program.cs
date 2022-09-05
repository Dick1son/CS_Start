/*
//Task 1. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
bool CheckTriangle (int sideA, int sideB, int sideC){
    bool result = false;
    if (sideA < sideB + sideC && sideB < sideA + sideC && sideC < sideB + sideA) result = true;

    return result;
}

Console.WriteLine("Проверим возможен ли треугольник с вашими сторонами!");
Console.Write("Первая сторона треугольника равна: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Вторая сторона треугольника равна: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Третья сторона треугольника равна: ");
int num3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Возможен ли треугольник с вашими сторонами: {CheckTriangle(num1, num2, num3)}");
*/

/*
//Task 2. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
void Fibonacci (int num1, int num2, int quantity){
    Console.Write($"{num1} {num2}");
    int current;
    for (int i = 0; i < quantity; i++){
        current = num1 + num2;
        num1 = num2;
        num2 = current;
        Console.Write($" {current}");
    }
}

Console.Write("Сколько чисел Фибоначчи вы хотите видеть?: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());

Fibonacci(n1, n2, size);
*/

/*
//Task 3. Напишите программу, которая будет преобразовывать десятичное число в двоичное.
string Binary(int num)
{
    string elem = string.Empty;

    while (num > 0)
    {
        int n = num % 2;
        elem = Convert.ToString(n) + elem;
        num = num / 2;
    }
    return elem;
}
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
string result = Binary(n);
Console.WriteLine(result);
*/