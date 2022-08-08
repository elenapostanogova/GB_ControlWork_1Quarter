// method for selecting array elements
string[] SelectArrayElements(string[] array)
{
    int i = 0;
    int j = 0;
    int limLenght = 3;
    string[] result = new string[array.Length];

    while (i < array.Length)
    {
        if(array[i].Length <= limLenght)
        {
            result[j] = array[i];
            j++;
        }
        i++;
    }
    return result;
}

// method for displaying array elements
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] +" ");
    }
    Console.WriteLine();
}


// input data
string[] arrayIn1 = new string[4] {"hello", "2", "world", ":-)"};
string[] arrayIn2 = new string[4] {"1234", "1567", "-2", "computer science"};
string[] arrayIn3 = new string[3] {"Russia", "Denmark", "Kazan"};

// output data
string[] arrayOut1 = SelectArrayElements(arrayIn1);
string[] arrayOut2 = SelectArrayElements(arrayIn2);
string[] arrayOut3 = SelectArrayElements(arrayIn3);
PrintArray(arrayOut1);
PrintArray(arrayOut2);
PrintArray(arrayOut3);


