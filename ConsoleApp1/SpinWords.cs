using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
    public static string SpinWords(string sentence)
    {
        string[] words = sentence.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        int i;
        for (i = 0; i < words.Length; i++)
        {
            if (words[i].Length > 4)
            {
                var word = new string(words[i].ToCharArray().Reverse().ToArray());
                words[i] = word;
            }
            
        }
        return String.Join(" ", words);

    }
}