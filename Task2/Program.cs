int sumnum(int num) //11
{
    int result = 0;
    while (num > 0)
    {
        result += num % 10;
        num = num / 10;
    }
    return result;
}

Console.Write("Введите число: ");
int UserNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма всех цифр числа {UserNum} = {sumnum(UserNum)}");




// void sumnum(string num)
// {
//     int len = num.Length;
//     int sum =  0;

//     for(int i = 0; i == len; i++ )
//     {
//         Convert.ToInt32(num[i]);
//         sum = 0 + num[i];
//     }

//     Console.Write(sum);
// }