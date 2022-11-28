namespace ConsoleApp18;
public static class Extension
{
    public static bool IsOdd(this int num)
    {
        if (num % 2 != 0)
            return true;
        return false;
    }
    public static bool IsEven(this int num)
    {
        if (num % 2 == 0)
        {
            return true;
        }
        return false;
    }
    public static bool IsContainsDigit(this string str)
    {
        for (int i = 0; i < str.Length; i++)
        {
            if (Char.IsDigit(str[i]))
            {
                return true;
            }
        }
        return false;
    }
}
    

