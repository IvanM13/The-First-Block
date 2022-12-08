/*Задача.Написать программу, которая из имеющегося массива cтрок формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
 При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами
 */


string[] ArrayInit(int size
{
    string[] array = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива -> ");
        array[i] = Console.ReadLine()!;
        Console.WriteLine();
    }
    return array;
}


int GetNumber(string message)
{
    Console.WriteLine(message);
    bool isCorrect = false;
    int result = 0;
    while (!isCorrect)
        if (int.TryParse(Console.ReadLine(), out result))
            isCorrect = true;
        else
            Console.WriteLine("Введено не число. Повторите ввод.");
    return result;
}

string[] Array2 (string[] array)
{
    string[] resultArray = new string[0];
    int anotherSize = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            anotherSize++;
            Array.Resize(ref resultArray, anotherSize);
            resultArray[resultArray.Length - 1] = array[i];
        }
    }
    return resultArray;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1) Console.Write(", ");
    }
    Console.Write("]");
}

int size = GetNumber("Введите размерность массива");
string[] array = ArrayInit(size);
string[] resultMatrix = Array2(array);
PrintArray(array);
Console.Write(" -> ");
PrintArray(resultMatrix);