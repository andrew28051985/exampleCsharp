// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19  [-4, -6, 89, 6] -> 0

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
// Метод определения четности числа
bool IsEven(int number)
{
    if (number % 2 == 0) return true;
    return false;
}
// Метод нахождения суммы нечетных элементов массива
int GetSumNotEvenElement(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (IsEven(i) || array[i] == 0)
        {
            count = count;
        }
        else 
        {
            count += array[i];
        }
    }
    return count;
}

// Начало программы
int[] arrayInput = EnterArray(5, 0, 10);
PrintArray(arrayInput);
Console.WriteLine(" -> " + GetSumNotEvenElement(arrayInput));
