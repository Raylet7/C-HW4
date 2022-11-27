// Программа, принимающая число и выдающая сумму цифр в числе. 
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int GetDigitsSum(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number /= 10;
    }
    return result;
}
Console.WriteLine("Программа определения суммы цифр числа.");
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
if (number >= 0)
{
    Console.WriteLine("Сумма цифр числа равна: " + GetDigitsSum(number));
}
else
{
    number *= -1;
    Console.WriteLine("Сумма цифр числа равна: " + GetDigitsSum(number));
}