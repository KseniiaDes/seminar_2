// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8


int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число от 10 до 99: {number}");

// int n1 = number / 10;
// int n2 = number % 10;

// if (n1 > n2) Console.WriteLine($"Наибольшая цифра числа: {n1}");
// else Console.WriteLine($"Наибольшая цифра числа: {n2}");

//Console.WriteLine($"Наибольшая цифра числа: {Math.Max(n1, n2)}");

int MaxDigit(int num) //int num = number
{
    int n1 = num / 10;
    int n2 = num % 10;
    if (n1 > n2) return n1;
    return n2; // не нужен else, т.к. если if будет true, эта строка выполняться не будет!
}

int maxDigit = MaxDigit(number); //int num = number
// int maxDigit2 = MaxDigit(34); //int num = 34
// int maxDigit3 = MaxDigit(65); //int num = 65
// int maxDigit4 = MaxDigit(77); //int num = 77

Console.WriteLine($"Наибольшая цифра числа: {maxDigit}");
// Console.WriteLine($"Наибольшая цифра числа: {maxDigit2}");
// Console.WriteLine($"Наибольшая цифра числа: {maxDigit3}");
// Console.WriteLine($"Наибольшая цифра числа: {maxDigit4}");