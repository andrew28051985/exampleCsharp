//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// метод ввода чисел в консоле
int GetInputNumber(int a)
{
    Console.WriteLine("Введите элемент массива " + a + ": ");
    return Convert.ToInt32(Console.ReadLine());  
}
// Метод запии массива
int[] EnterArray(int lengthArray)
{
    int[] array = new int[lengthArray];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = GetInputNumber(i);
    }

    return array;
}
// Метод вывода массива в консоль
void PrintArray(int[] array)
{
    Console.Write("Получился массив: [");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + (i == array.Length - 1 ? "" : ", "));
    }
    Console.Write("]");
    Console.WriteLine();
}

// Вывод массива в консоль
PrintArray(EnterArray(8));
