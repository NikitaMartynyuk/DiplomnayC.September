// Задача: Написать программу, которая из имеющегося массива строк формирует
// новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] inputArray = { "Hello", "2", "world", ":-)" };
string[] outputArray = GetShortStrings(inputArray);

Console.WriteLine("Input array: ");
PrintArray(inputArray);

Console.WriteLine("Output array");
PrintArray(outputArray);

static string[] GetShortStrings(string[] InputArray);
{
    int outputLength = 0;
    for (int i = 0; i < inputArray.Length; i++)
        if (inputArray[i].Length <= 3)
        {
            outputLength++;
        }
}

string[] outputArray = new string[outputLength];
int outputIndex = 0 ;
for (int i = 0; i < inputArray.Legth;i ++)
{
    
}