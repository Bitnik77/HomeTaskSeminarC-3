//Задача №19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли
//оно палиндромом
Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);
if (number % 100 /10 == number % 10000 / 1000 && number % 10 == number / 10000)
   Console.WriteLine($"Введенное число {number} является палиндромом");
else 
   Console.WriteLine($"Введенное число {number} не является палиндромом");