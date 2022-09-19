// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

Console.Write("Input integer number: ");
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine(ConvTo2(num));

string ConvTo2(int num)
{
    string result = "";

    while (num > 0)
        {
            string substring = $"{num % 2}";
            result = result.Insert(0, substring);
            num = num / 2;
        }
    return result;
}
