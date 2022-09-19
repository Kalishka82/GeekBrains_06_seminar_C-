// Задача 45: Напишите программу, которая будет создавать копию заданного массива с 
// помощью поэлементного копирования.

int[] array = {12, 3, 45, 8, 14};

PrintCopyArray(CreateCopyArray(array));

int[] CreateCopyArray(int[] array)
{
    int[] arrayCopy = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
        {
            arrayCopy[i] = array[i];
        }
    return arrayCopy;
}

void PrintCopyArray(int[] arrayCopy)
{
    foreach (int item in arrayCopy)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}
