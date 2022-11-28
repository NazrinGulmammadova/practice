string word = "melek";
string GetWord(string letters)
{
    string result = string.Empty;
    for (int i = letters.Length - 1; i >= 0; i--)
    { 
        result+=letters[i];
    }
    return result;
}
Console.WriteLine(GetWord(word));
