string[] array = new string[] { "1234", "!!!", "world", "%2&^/", "git" };

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
void Formation(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        string element = arr[i];
        if (element.Length <= 3)
        {
            arr[i] = element;
    }
        else arr[i] = string.Empty;
    }
}
PrintArray(array);
Formation(array);
Console.Write("Ответ-> ");
PrintArray(array);