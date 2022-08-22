/*
//Task 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int SecondDigit(int num){
    int result = num % 100 / 10;

    return result; 
}

int randomNumber = new Random().Next(100, 1000);
int completeNumber = SecondDigit(randomNumber);

Console.Write($"Second digit of {randomNumber} is {completeNumber}.");
*/

/*
//Task 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int ThirdDigit(int num){
    int result = num % 10;

    return result; 
}

Console.Write("Enter your number: ");
int number = Convert.ToInt32 (Console.ReadLine());

if (number < 100) 
    Console.Write("Error: not found third digit");
else{
    int completeNumber = ThirdDigit(number);
    Console.Write($"Third digit of {number} is {completeNumber}.");
}
*/

/*
//Task 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.(я не знаю зачем тут метод)
Console.Write("Enter the day of the week as a number: ");
int num = Convert.ToInt32 (Console.ReadLine());

if (num > 0 && num < 6)
    Console.Write("This day is weekday.");
else if (num > 0 && num > 5 && num < 8)
    Console.Write("This day is weekend.");
*/