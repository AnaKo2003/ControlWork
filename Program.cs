string[] inputArray = { "hello", "2", "world", ":-)"};
string[] resultArray = new string[inputArray.Length];

void ArraysOfStrings(string[] inputArray, string[] resultArray)
{
    int count = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
      if(inputArray[i].Length <= 3)
        {
        resultArray[count] = inputArray[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

ArraysOfStrings(inputArray, resultArray);
PrintArray(resultArray);