void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length - 1; i++)

        Console.Write("\"" + array[i] + "\",");
    Console.Write("\"" + array[array.Length - 1] + "\"");
    Console.WriteLine();
}

string[] SplitArray(string array)
{
    string[] stringArray = array.Split(' ');
    int i = 0;
    int j = 0;
    int count = 0;
    for (int k = 0; k < stringArray.Length; k++)
    {
        if ((stringArray[k].Length <= 3) && (!String.IsNullOrEmpty(stringArray[k])))
        {
            count++;
        }
    }
    string[] finalArray = new string[count];
    i = 0;
    foreach (var sub in stringArray)
    {
        if ((stringArray[i].Length <= 3) && (!String.IsNullOrEmpty(sub)))
        {
            finalArray[j] = stringArray[i];
            i++;
            j++;
        }
        else
        {
            i++;
        }
    }
    return finalArray;
}

Console.WriteLine("Введите cтроки через пробел");
string[] array = SplitArray(Console.ReadLine().Trim());
PrintArray(array);