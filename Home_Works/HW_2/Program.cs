
//Task 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int SecondDigit(int num){
    int result = num % 100 / 10;

    return result; 
}

int randomNumber = new Random().Next(100, 1000);
int completeNumber = SecondDigit(randomNumber);

Console.Write($"Second digit of {randomNumber} is {completeNumber}.");