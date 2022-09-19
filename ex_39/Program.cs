// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент
//  будет на первом месте, а первый - на последнем и т.д.)

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9};
PrintArray (numbers);

ReverseArray (numbers);
PrintArray (numbers);

void Swap (ref int a, ref int b) {  // передаём значения по ссылке
    int c = a;
    a = b;
    b = c;
}

void PrintArray (int[] numbers) => Console.WriteLine (string.Join (", ", numbers));

void ReverseArray (int[] numbers) {
    for (int i = 0; i < numbers.Length / 2; i++) {
        Swap (ref numbers[i], ref numbers[^(i + 1)]);
    }
}

// (x, y) => x + y;

// int Sum (int x, int y) {return x + y;}


// int a = 5;
// int b = 2;
// Swap(ref a, ref b);
// Console.WriteLine($"{a}, {b}");

// void Swap(int a, int b) // передаем значения по ссылке
// {
//     int c = a;
//     a = b;
//     b = c;
// }