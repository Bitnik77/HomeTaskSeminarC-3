// Задача №21. Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 3D пространстве
Console.Clear();
Console.Write("Введите координату X первой точки: ");
int X1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Y первой точки: ");
int Y1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Z первой точки: ");
int Z1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату X второй точки: ");
int X2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Y второй точки: ");
int Y2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Z второй точки: ");
int Z2 = int.Parse(Console.ReadLine()!);

double result = Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2) + Math.Pow(Z1 - Z2, 2));
Console.WriteLine($"Расстояние между точками {result:f2}");