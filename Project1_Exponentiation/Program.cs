// Программа, принимающая числа А и В 
// и возводящая число A в натуральную степень B
// (используя цикл).
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int ExponentiationFor(int numberA, int exponentB)
{
    int result = 1;
    for (int i = 1; i <= exponentB; i++)
    {
        result = result * numberA;
    }
    return result;
}
Console.WriteLine("Программа возведения числа в натуральную степень");
Console.Write("Введите число: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.Write("Введите натуральную степень: ");
int exponentB = int.Parse(Console.ReadLine()!);
if (exponentB < 1)
{
    Console.WriteLine("Неверный ввод");
}
else
{
    Console.WriteLine(numberA + "^" + exponentB + " = " + ExponentiationFor(numberA, exponentB));
}