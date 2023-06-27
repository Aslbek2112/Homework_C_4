/*Задача 29.
Напишите программу, которая задает массив из 8 элементов и выводит их на экран.
*/
Console.Clear();
int[] array = new int[8]; 
Random random = new Random(); 
        

for (int i = 0; i < array.Length; i++) 
{
    array[i] = random.Next(10);
}
        

Console.WriteLine("Массив:");
for (int i = 0; i < array.Length; i++) 
{
    Console.Write(array[i] + " ");
}
