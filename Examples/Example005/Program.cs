/*
//Task 1. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
void FindInterval(int num){
    if (num == 1) Console.WriteLine($"Диапазон возможных координат в четверти {num}: X > 0, Y > 0");
    if (num == 2) Console.WriteLine($"Диапазон возможных координат в четверти {num}: X < 0, Y > 0");
    if (num == 3) Console.WriteLine($"Диапазон возможных координат в четверти {num}: X < 0, Y < 0");
    if (num == 4) Console.WriteLine($"Диапазон возможных координат в четверти {num}: X > 0, Y < 0");
    if (num < 0 || num > 4) Console.WriteLine("Четверти с таким номером не существует");
}

Console.Write("Введите порядковый номер четверти: ");
int  quad = Convert.ToInt32 (Console.ReadLine());
FindInterval(quad);
*/

/*
//Task 2. Напишите программу, которая принимает на вход число (n) и выдаёт квадраты чисел от 1 до n.
void Quad(int num){
    int i = 1;
    while (i <= num){
        if (i == n)
            Console.Write($"{i * i}, ");
        else
            Console.Write($"{i * i}. ");
        i++;
    }
}

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32 (Console.ReadLine());
Quad(number);
*/


//Task 3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
