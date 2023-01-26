// Задача №23. Напишите программу, которая принимает на вход число (N) и выдаёт
// таблицу кубов чисел от 1 до N
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int count = 1;
while (count <= number)
{
    Console.Write($"{count*count*count}");
    if (count != number) Console.Write(", ");
    count++;
}