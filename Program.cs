string[] array = new string[5] {"1678", "88", "Tanya", "yes", "no", "go", "hello"};
string[] newarray = new string[array.Length];
void SecondArrayWithIF(string[] array, string[] newarray)
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