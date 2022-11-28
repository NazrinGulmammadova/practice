string GetWord(char sign, int[] arr)
{
    string str = string.Empty;
    for (int i = 0; i < arr.Length-1; i++)
    {
        str += arr[i];
        str += sign;
    }
    str+=arr[arr.Length-1];
    return str;
}
Console.WriteLine(GetWord('-', new int[] { 1, 2, 3 }));