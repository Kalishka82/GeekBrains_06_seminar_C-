// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа 
// Фибоначчи: 0 и 1.

Console.Write("Input integer number: ");
int n = int.Parse(Console.ReadLine()!);

PrintArray(getFibonacci(n));

int[] getFibonacci(int n)
{
    int[] fibs = new int[n];
    fibs[0] = 0;
    fibs[1] = 1;

    for (int i = 2; i < n; i++)
        fibs[i] = fibs[i - 2] + fibs[i - 1];

    return fibs;
}

void PrintArray(int[] fibs)
{
    foreach (int fib in fibs)
    {
       Console.Write($"{fib} ");
    }
    Console.WriteLine();
}    