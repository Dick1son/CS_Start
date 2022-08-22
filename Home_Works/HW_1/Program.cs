/*
// Task 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.(не уточнен тип чисел, будем считать что и вещественные тоже)
Console.Write("Enter the first number: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the second number: ");
double num2 = Convert.ToDouble(Console.ReadLine());

if (num1 > num2){
    Console.WriteLine($"{num1} more than {num2}");
}else{
    Console.WriteLine($"{num2} more than {num1}");
}
*/

/*
//Task2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Enter the first number: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the second number: ");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the third number: ");
double num3 = Convert.ToDouble(Console.ReadLine());
//double max = 

if (num1 > num2 && num1 > num3){
    Console.WriteLine($"The maxiamal number is {num1}");
}else if (num2 > num1 && num2 > num3){
    Console.WriteLine($"The maxiamal number is {num2}");
}else 
    Console.WriteLine($"The maxiamal number is {num3}");
*/

/*
//Task 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("Enter your number: ");
double num = Convert.ToDouble(Console.ReadLine());

if (num % 2 == 0)
    Console.WriteLine($"{num} is an even number");
else 
    Console.WriteLine($"{num} is an odd number");
*/

/*
//Task 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Enter your number: ");
double num = Convert.ToDouble(Console.ReadLine());
int i;

Console.Write(num + " -> ");
if (num % 2 == 0){
    for(i = 1; i <= num; i++){
        if (i % 2 == 0 && i != num ) Console.Write(i + ", ");
        if (i % 2 == 0 && i == num ) Console.Write(i + ".");
    }
}else{
     for(i = 1; i <= num; i++){
        if (i % 2 == 0 && i != num - 1 ) Console.Write(i + ", ");
        if (i % 2 == 0 && i == num - 1 ) Console.Write(i + ".");
    }
}
*/