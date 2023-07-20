int Method (int minDigit, int maxDigit)
{
    int count = 8;
    int i = 0;
    int [] array = new int[] {};
    while (i < count)
    {
        array[i] = new Random().Next(minDigit, maxDigit + 1);
        i++;
    }
    return Convert.ToInt32(array);
}

Console.WriteLine("Введите минимальное значение: ");
int minD = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение: ");
int maxD = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Массив: [{Method(minD, maxD)}]");