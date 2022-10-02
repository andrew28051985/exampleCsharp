// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21;

// Ввод заданого числа через консоль
int GetNumber()
{    
    return Convert.ToInt32(Console.ReadLine());    
}
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
// Метод, определяющий сколько пар элементов в массиве
int GetNumberPairArray(int[] array)
{
    int pair = 0;
    if (array.Length % 2 == 0)
    {
        pair = array.Length / 2;
    }
    else 
    {
        pair = array.Length / 2 + 1;
    }
    return pair;
}
// Метод, определяющий четность количества пар элементов в массиве
bool IsEvenPairArray(int numberPair)
{
    if (numberPair % 2 == 0)
        return true;
    return false;    
}
// Метод вычисляющий произведение пар чисел в массиве
int[] GetMulNumber(int[] array)
{
    // Определяем сколько пар в массиве
    int pair = GetNumberPairArray(array);
    // Определяем четное или не четное количество пар элементов в массиве
    bool even = IsEvenPairArray(pair);
    // Создаем новый массив для записи результатов
    int[] arrayOut = new int[pair];
    // Находим пары и вычисляем их произведение
    for (int i = 0; i < pair; i++)
    {
        int newNumber = array[i] * array[array.Length - i - 1];
        if (even)
        {
            arrayOut[i] = newNumber;
        }
        else
        {
            if (i == pair - 1)
            {
                arrayOut[i] = array[i];
            }
            else 
            {
                arrayOut[i] = newNumber;
            }
        }
    }
    return arrayOut;
}

// Начало программы
Console.WriteLine("Введите параметры для создания массива: ");
Console.Write("Введите длину массива: ");
int lengthArray = GetNumber();
Console.Write("Введите минимальное число массива: ");
int min = GetNumber();
Console.Write("Введите максимальное число массива: ");
int max = GetNumber();
Console.WriteLine("Выведем получившийся массив и произведения пар элементов: ");
int[] arrayInput = EnterArray(lengthArray, min, max);
PrintArray(arrayInput);
Console.Write(" -> ");
PrintArray(GetMulNumber(arrayInput));
Console.WriteLine();