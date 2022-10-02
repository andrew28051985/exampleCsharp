// Задача 33а: Задайте массив. Напишите программу, которая выводит
// индексы всех элементов, равных заданному числу в массиве

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
// Ввод заданого числа через консоль
int GetNumber()
{    
    return Convert.ToInt32(Console.ReadLine());    
}
// Вывод элементов массива равных заданному числу
void GetElem(int number, int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            if (count == 0)
            {
                Console.Write(i); 
                count++;  
            }
            else
            {
                Console.Write(", " + i);
                count++;
            }
        }        
        if (i == array.Length - 1 && count == 0)
        {
            Console.Write("В массиве нет совпадений с заданным числом " + number);
        }
    }
    Console.WriteLine();
}

// Начало программы
Console.Write("Введите число, которое проверим на совпадение с числами массива: ");
int inputNumber = GetNumber();
Console.Write("Введите длину массива: ");
int lengthArray = GetNumber();
Console.Write("Введите минимальное число массива: ");
int min = GetNumber();
Console.Write("Введите максимальное число массива: ");
int max = GetNumber();
int[] arrayInput = EnterArray(lengthArray, min, max); 
Console.WriteLine("Выведем получившийся массив и индексы совпадений: ");
PrintArray(arrayInput);
Console.Write(" -> ");
GetElem(array: arrayInput, number: inputNumber);
