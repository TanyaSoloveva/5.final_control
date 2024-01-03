string[] array = new string[7] {"1678", "88", "Tanya", "yes", "no", "go", "hello"};
string[] newarray = new string[array.Length];
void SecondArray(string[] array, string[] newarray)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        newarray[count] = array[i];
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
    Console.WriteLine();
}
SecondArray (array, newarray);
PrintArray(newarray);