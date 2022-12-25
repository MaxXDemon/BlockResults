int NumberRequiredElements (string [] array)
{
    int size = 0; 
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        size++;
    }
    return size;
}

string [] СreatingNewArray (string [] array, int size)
{
    string [] newArray = new string [size];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

void PrintArray (string [] newArray)
{
    for (int j = 0; j < newArray.Length; j++)
    {
        Console.Write($" {newArray[j]}");
    }
    Console.WriteLine();
}

string [] array = new string [] {"Tom","Sam","Bob","Maksim","Jonny","Max"};
PrintArray(array);
PrintArray(СreatingNewArray(array, NumberRequiredElements(array)));