using System;

public static class Isogram
{

    public static bool IsIsogram(string word)
    {
        string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        char[] charAlpha = alphabet.ToCharArray();
        word = word.ToUpper();
        char[] charWord = word.ToCharArray();
        string bank = "";
        foreach (char c in charWord)
        {
            if (c == '-' || c == ' ') continue;
            if (!bank.Contains(c))
            {
                bank += c;
            }
            else
            {
                return false;
            }
        }
        return true;
    }
}
