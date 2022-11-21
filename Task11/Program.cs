//11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);

int NewNumber(int num)
{
    int firstNumber = num / 100 * 10;
    int secondNumber = num % 10;
    int fullNumber = firstNumber + secondNumber;
    return fullNumber;
}

int newNumber = NewNumber(number);

Console.WriteLine($"Случайное трехзначное число: {number}, если удалить из числа вторую цифру получится: {newNumber}");
