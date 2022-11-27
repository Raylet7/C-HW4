// Программа, принимающая целое или дробное число и 
// выдающая количество цифр в нём.
// 452 -> 3
// 82 -> 2
// 9,012 ->4
int GetDigitsNumber(decimal number)
{
    int count;
    for (count = 0; number > 1; count++)
    {
        number /= 10;
    }
    return count;
}
Console.WriteLine("Программа определения количества цифр в целом или дробном числе.");
Console.WriteLine("Введите число:");
decimal number = decimal.Parse(Console.ReadLine()!);
if (number == 0)
{
    Console.WriteLine("Количество цифр в числе: 1");
}
else
{
    if (number < 0)
    {
        number *= -1;
    }
    while (number % 1 > 0)
    {
        number *= 10;
    }
    Console.WriteLine($"Количество цифр в числе: {GetDigitsNumber(number)}");
}