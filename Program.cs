// Задача. Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше или равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] specifiedArray = new string[] { "1234", "C#", "654378", "teftel", "cat", "git", "gb", "777" };
Console.WriteLine("Заданный массив: ");
PrintArray(specifiedArray);
int lengthCharacters = 3;

int lengthSecondArr = DetermineLengthSecondArr(specifiedArray, lengthCharacters);
string[] secondaryArray = new string[lengthSecondArr];
FillingSecondArr(specifiedArray, secondaryArray, lengthCharacters);
Console.WriteLine("Сформированный массив: ");
PrintArray(secondaryArray);

// Найдем длину будущего массива.
int DetermineLengthSecondArr(string[] arr, int lengthChar)
{
    int counter = 0;
    for (int i = 0; i <= arr.Length - 1; i++)
    {
        if (arr[i].Length <= lengthChar) counter++;
    }
    return counter;
}

// Наполнение сформированного массива данными.
void FillingSecondArr(string[] primaryArr, string[] secondArr, int lenSecondArr)
{
    int arrIndex = 0;
    for (int i = 0; i <= primaryArr.Length - 1; i++)
    {
        if (primaryArr[i].Length <= lenSecondArr)
        {
            secondArr[arrIndex] = primaryArr[i];
            arrIndex++;
        }
    }
}

// Метод печати массива.
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}