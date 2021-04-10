using System;
using System.Linq;

public class Dubstep
{
    //Задача Dubstep
    public static string SongDecoder(string input)
    {
        string[] words = input.Split("WUB");
        string output = "";
        for (int i = 0; i < words.Length; i++) // по поводу постфиксной операции писал в SpinWords
        {
            if (words[i] != "")
            {
                output += " " + words[i];   // можно было сразу написать через интерполяцию
                                            // ниже у тебя output.Remove(0, 1), удаляющий первый пробел
                                            // ты мог бы делать проверку на пустую строку string.IsNullOrEmpty(output)
                                            // и если строка не пустая, то ставишь пробел, иначе ничего не делаешь
            }

        }
        output = output.Remove(0, 1);
        return output;

        // Я бы сделал вот так:
        // return string.Join(' ', input.Split("WUB").Where(str => !string.IsNullOrEmpty(str)));
    }
}