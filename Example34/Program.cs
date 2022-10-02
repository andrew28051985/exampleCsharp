// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Метод запиcи массива
int[] EnterArray(int lengthArray)
{
    int[] array = new int[lengthArray];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(99, 999);
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
// Метод подсчета четных цифр в массиве
int GetValueEvenInArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (IsEven(array[i])) count++;
    }
    return count;
}

// Начало программы
int[] arrayInput = EnterArray(5);
PrintArray(arrayInput);
Console.WriteLine(" -> " + GetValueEvenInArray(arrayInput));