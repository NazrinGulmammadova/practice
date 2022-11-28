string word = "salam";

string GetWord(string word, char letter, char newLetter)
{
    string newWord = string.Empty;
    for (int i = 0; i < word.Length; i++)
    {
        if (word[i] == letter)
        {
            newWord += newLetter;
        }
        else
        {
            newWord += word[i];
        }

    }
    return newWord;
}
Console.WriteLine(GetWord(word, 'm', 'n'));
