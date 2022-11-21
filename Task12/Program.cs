// 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму. 
// Если число 1 не кратно числу 2, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


Console.WriteLine("Для того чтобы узнать является ли одно число кратным другому, введите два числа: ");
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int Multiplicity(int num1, int num2)
{
    if (num1<num2) return -1;
    return num1 % num2;
}

int multiplicity = Multiplicity(number1, number2);
if (multiplicity == -1) Console.WriteLine($"Число {number1} не кратно числу {number2}, целого остатка нет");
else if (multiplicity == 0) Console.WriteLine($"Число {number1} кратно числу {number2}");
else Console.WriteLine($"Число {number1} не кратно числу {number2}, остаток {multiplicity}");