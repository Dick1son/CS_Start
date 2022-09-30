//Task 1.  Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/* 
void ShowNums(int m, int n){
    if (n > m) ShowNums(m, n - 1);

    Console.Write(n + " ");
}

Console.Write("Начало отсчета: ");
int i = Convert.ToInt32 (Console.ReadLine());
Console.Write("Конец отсчета: ");
int j = Convert.ToInt32 (Console.ReadLine());

ShowNums(i, j);
*/

//Task 2. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/* 
int ShowNums(int m, int n){
    if (n <= m){
        Console.Write(n + " "); 
        return ShowNums(m, n + 1) + n; 
          
    } 
    else return 0;

    
}

Console.Write("Начало отсчета: ");
int i = Convert.ToInt32 (Console.ReadLine());
Console.Write("Конец отсчета: ");
int j = Convert.ToInt32 (Console.ReadLine());

Console.Write($"\nСумма натуральных элементов в промежутке от {i} до {j}: {ShowNums(j, i)}.");
*/

//Task 3. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/* 
int Akkerman(int m, int n){
    if (m == 0){
        return n + 1;
    }
    else if ((m > 0) && (n == 0)){
        return Akkerman(m - 1, 1);
    }
    else if ((m > 0) && (n > 0)){
        return Akkerman(m - 1, Akkerman(m, n - 1));
    } else
        return n + 1;
}

Console.Write("Первое число(m): ");
int i = Convert.ToInt32 (Console.ReadLine());
Console.Write("Второе число(n): ");
int j = Convert.ToInt32 (Console.ReadLine());

Console.Write($"\nФункция Аккермана для m = {i}, n = {j} равна {Akkerman(i, j)}.");
 */