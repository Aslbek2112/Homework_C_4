/*Задача 27.
Напишите программу, которая принимает на вход число и выдает сумму цифр в числе
*/

Console.Clear();
// Ввод числа
Console.Write("Введите число: ");
if (!int.TryParse(Console.ReadLine(), out int userInput)) 
{
    Console.WriteLine("Ошибка ввода числа");
    return;
}
int number = userInput;        

int sum = 0;
while (number > 0) 
{
    sum += number % 10;
    number /= 10;
}
        
Console.WriteLine($"Сумма цифр числа {userInput}  --> {sum}");