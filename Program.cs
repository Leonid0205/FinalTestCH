string[] CreateStringArray(int numberOfWords)
{
    string[] array = new string[numberOfWords];
    for (int i = 0; i < numberOfWords; i++)
    {
        Console.Write($"Input {i + 1} word: ");
        array[i] = Console.ReadLine();
    }
    return array;
}
void ShowStringArray(string[] array)
{
    Console.Write("[" + string.Join(", ", array) + "]");
    Console.WriteLine();
}
int ArraySize(string[] array)
{
    int wordLength = 3;
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= wordLength)
        {
            count++;
        }
    }
    return count;
}
string[] ArrayThreeLenght(string[] array, int count)
{
    string[] arrayChanged = new string[count];
    int wordLength = 3;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= wordLength)
        {
            arrayChanged[i] = array[i];
        }
    }
    return arrayChanged;
}
Console.Write("Input number of words: ");
int numberOfWords = Convert.ToInt32(Console.ReadLine());
string[] array = CreateStringArray(numberOfWords);
ShowStringArray(array);
int count = ArraySize(array);
string[] arrayRes = ArrayThreeLenght(array, count);
ShowStringArray(arrayRes);