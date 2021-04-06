using System;
using System.Linq;

public class Dubstep
{
    //Задача Dubstep
    public static string SongDecoder(string input)
    {
        string[] words = input.Split("WUB");
        string output = "";
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i] != "")
            {
                output += " " + words[i] ;
            }

        }
        output = output.Remove(0,1);
        return output;
    }
}