
using System;

public class PalindromeSut : IPalindromeSut
{
    public bool IsStringPalindrome(string input)
    {
        IfEmptyThrow(input);
        return input == ReverseString(input);
    }

    public bool IsPhrasePalindrome(string input)
    {
        IfEmptyThrow(input);

        var strSource = input.Split(' ');
        int wordcount = strSource.Length;

        var strReversed = ReversePhrase(strSource);
        return ComparePhrase(strSource, strReversed);
    }

    private void IfEmptyThrow(string input)
    {
        if (string.IsNullOrEmpty(input)) throw new ArgumentNullException("test");
    }

    private bool ComparePhrase(string[] strSource, string[] strReversed)
    {

        bool match = true;
        int j = 0;
        for (int i = 0; i < strSource.Length; i++)
        {
            if (strReversed[j] != strSource[i])
            {
                match = false;
                break;
            }
            j++;
        }

        return match;
    }

    private string[] ReversePhrase(string[] strSource)
    {
        int wordcount = strSource.Length;
        string[] temp = new string[wordcount];
        int j = 0;
        for (int i = wordcount - 1; i >= 0; i--)
        {
            temp[j++] = strSource[i];
        }
        return temp;
    }

    private string ReverseString(string input)
    {
        char[] strArr = input.ToCharArray();
        string temp = string.Empty;
        for (int i = strArr.Length - 1; i >= 0; i--)
        {
            temp += strArr[i];
        }

        return temp;
    }

}

public interface IPalindromeSut
{
    public bool IsStringPalindrome(string input);
    public bool IsPhrasePalindrome(string input);
}