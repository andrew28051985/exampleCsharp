// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Метод запиcи массива
int[] EnterArray(int lengthArray, int minNumber, int maxNumber)
{
    int[] array = new int[lengthArray];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minNumber, maxNumber);
    }

    return array;
}
// Метод вывода массива в консоль
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + (i == array.Length - 1 ? "" : ", "));
    }
    Console.Write("]");
}
// Метод определения минимального элемента массива
int GetMinElementArray(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min >= array[i])
        {
            min = array[i];
        }
    }
    return min;
}
// Метод определения максимального элемента массива
int GetMaxElementArray(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max <= array[i])
        {
            max = array[i];
        }
    }
    return max;
}

// Начало программы
int[] arrayInput = EnterArray(5, 0, 99);
PrintArray(arrayInput);
Console.WriteLine(" -> " + (GetMaxElementArray(arrayInput) - GetMinElementArray(arrayInput)));
