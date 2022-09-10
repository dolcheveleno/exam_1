/*
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равно 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

void PrintArray(string[] stringArray)
{
    for (int i = 0; i < stringArray.Length; i++)
        Console.Write(stringArray[i] + " ");
}

int FindElements(string[] stringArray, int length)
{
    int count = 0;
    foreach (string s in stringArray)
    {
        if (s.Length <= length) count++;
    }
    return count;
}
 
string[] NewArray(string[] stringArray, int count, int length, int i = 0)
{
    string[] newStringArray = new string[count];
    foreach (string s in stringArray)
    {
        if (s.Length <= length)
        {
            newStringArray[i] = s;
            i++;
        }
    }
    return newStringArray;
}

string[] firstArray = { "Раз", "Два", "Три", "Четыре", "Пять", "467", "54657" };      
int lengthString = 3;    
int countElement = FindElements(firstArray, lengthString); 
Console.WriteLine("Изначально заданный массив: ");
PrintArray(firstArray);
Console.WriteLine();
if (countElement == 0)
{
    Console.WriteLine($"Массив не имеет элементов, длина которых меньше либо равна {lengthString} символа");
}
else
{
    Console.WriteLine($"Массив, сформированный из строк имеющегося массива, длина которых меньше либо равна {lengthString} символа: ");
    PrintArray(NewArray(firstArray, countElement, lengthString));
}