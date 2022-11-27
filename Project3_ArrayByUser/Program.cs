// Программа, задающая массив из 8 целых чисел с клавиатуры 
// и выводящая его на экран в одну строку.
void FillArrayByUser(int[] array)
{
    int count = 1;
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {count}-е целое число: ");
        array[i] = int.Parse(Console.ReadLine()!);
        count++;
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
Console.WriteLine("Программа создания пользователем массива из 8 целых чисел.");
int[] array = new int[8];
FillArrayByUser(array);
Console.WriteLine("Заданный массив:");
PrintArray(array);
Console.WriteLine();