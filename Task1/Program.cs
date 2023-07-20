Console.Write("Введите первое число: ");
int UserNumA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int UserNumB = Convert.ToInt32(Console.ReadLine());

qwe(UserNumA, UserNumB);

int qwe (int numA, int numB)
{
    int result = 1;
    for (int i = 0; i < numB; i++)
    {
        result *= numA;
    }
    return result;
}

int res = qwe(UserNumA, UserNumB);
Console.WriteLine($"Число {UserNumA} в степени {UserNumB} = {qwe(UserNumA, UserNumB)}");