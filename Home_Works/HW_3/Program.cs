/*
//Task 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
void CheckPalindrom(int num){
    int digit;
    int currentNum = num;
    int j = 10;
    int[] array = new int [5];

    for (int i = 0; i < 5; i++){
        digit = currentNum % 10;
        currentNum = num / j;
        array[i] = digit;
        j = j * 10; 
    }

    if (array[0] == array[4] && array[1] == array[3])
        Console.WriteLine($"Число {num} является палиндромом");
    else
        Console.WriteLine($"Число {num} не является палиндромом");
}

Console.Write("Отчаянно прошу, введите только пятизначное число: ");
int number = Convert.ToInt32 (Console.ReadLine());
CheckPalindrom(number);
*/

/*
//Task 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
void FindDistance(int x1, int y1, int z1, int x2, int y2, int z2 ){
    double result = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
    Console.WriteLine($"Расстояние между двумя точками в 3D пространстве равно {Math.Round(result, 2)}");
}

Console.Write("Введите координаты x1: ");
int xA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты y1: ");
int yA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты z1: ");
int zA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты x2: ");
int xB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты y2: ");
int yB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты z2: ");
int zB = Convert.ToInt32(Console.ReadLine());

FindDistance(xA, yA, zA, xB, yB, zB);
*/

/*
//Task 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void FindCube(int num){
    int cube = 1;
    Console.Write($"{num} -> ");
    for (int current = 1; current <= num; current++){
        cube = current * current * current;
        Console.Write($"{cube} ");
    }
}

Console.Write("Введите положительное целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

FindCube(number);
*/