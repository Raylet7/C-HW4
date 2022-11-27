// Программа, выводящая заполненный нулями и единицами массив из 8 элементов.
// Если единиц больше, чем нулей - TRUE, иначе - False.
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
void CompareNumberOfTwoValues(int[] array)
{
    int numberOfZero = 0;
    int numberOfOne = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == 0)
        {
            numberOfZero++;
        }
        else
        {
            numberOfOne++;
        }
    }
    if (numberOfOne == numberOfZero)
    {
        Console.WriteLine("Same - в массиве одинаковое количество единиц и нулей.");
    }
    else
    {
        if (numberOfOne > numberOfZero)
        {
            Console.WriteLine("TRUE - в массиве больше единиц, чем нулей.");
        }
        else
        {
            Console.WriteLine("False - в массиве больше нулей, чем единиц.");
        }
    }
}
Console.WriteLine("Программа создания заполненного нулями и единицами массива из 8 элементов.");
int[] array = new int[8];
FillArray(array);
Console.WriteLine("Массив:");
PrintArray(array);
Console.WriteLine();
CompareNumberOfTwoValues(array);