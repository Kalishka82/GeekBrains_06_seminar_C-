// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может 
// ли существовать треугольник со сторонами такой длины
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух 
// других сторон.

Console.Write("Введите длины сторон треугольника через пробел: ");
string sides = Console.ReadLine()!;
string[] parts = sides.Split(' ');
int a = int.Parse(parts[0]);
int b = int.Parse(parts[1]);
int c = int.Parse(parts[2]);

if (IsTriangleExist(a, b, c))
{
    Console.WriteLine("Треугольник существует");
}
else Console.WriteLine("Треугольник НЕ существует");


bool IsTriangleExist (int a, int b, int c)
{
    return a < b + c && b < c + a && c < a + b;
}