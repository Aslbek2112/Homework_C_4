/*Задача 25.
Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В. 
*/
Console.Clear();
// 1.Input
double a = GetNumberFromUser("Введите первое число: ", "Ошибка ввода данныx! Введите число!");
double b = GetNumberFromUser("Введите второе число: ", "Ошибка ввода данныx! Введите число!");
// 2. Calculation
double result = NumberDegree(a, b);
// 3. Вывод результата
Console.WriteLine($"{a} в степени {b} равно {result}");


//////////////////////////////////
static double GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        if(double.TryParse(Console.ReadLine(), out double number))
            return number;
    }
        Console.WriteLine(errorMessage);
}

static double NumberDegree(double number1, double number2)
{
    return Math.Pow(number1, number2);
}
