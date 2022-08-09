// // Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше или равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] MainArray = new string[6] { "summer", "5555", ":*)", "no", "!", "Petersburg" };
string[] NewArray = new string[MainArray.Length];

void CreateNewArrayByCondition(string[] MainArray, string[] NewArray)
{
    int j = 0;
    for (int i = 0; i< MainArray.Length; i++)
    {
        if (MainArray[i].Length <= 3)
        {
            NewArray[j] = MainArray[i];
            j++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i< array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

Console.WriteLine();
CreateNewArrayByCondition(MainArray, NewArray);
PrintArray(NewArray);