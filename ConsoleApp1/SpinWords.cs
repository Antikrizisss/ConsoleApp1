using System.Linq;
using System;

public partial class Kata
{
    //Задача Stop gninnipS My sdroW!
    public static string SpinWords(string sentence)
    {
        string[] words = sentence.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        int i; // переменную можно было объявить внутри цикла for (int i = 0; i < words.Length; i++)
        // По поводу i++: 1) эта штука называется "постфиксный инкремент"; 2) что она делает? она сначала возвращает значение,
        // а потом увеличивает его на 1. То есть:
        // int a = 1; int b = a++; 'b' будет равен 1, 'a' будет равен 2, потому что изначально постфиксный инкремент вернет значение, а затем увеличит его
        // Противоположностью постфиксных операций является префиксные операции. Что, например, делает префиксный инкремент? Он сначала увеличивает
        // значение на, а затем возвращает значение. То есть:
        // int a = 1; int b = ++a; 'b' будет равен 2, 'a' будет равен 2. Аналогичным образом работает и префиксный/постфиксный декремент
        // В твоем цикле использование постфиксного оператора ни на что не влияет, потому что компилятор сам все заменит при оптимизации,
        // но это нужно знать, особенно когда работаешь с перегрженной версией того или иного оператора
        // Я использую в циклах префиксную форму - ++i
        for (i = 0; i < words.Length; i++)
        {
            if (words[i].Length > 4)
            {
                var word = new string(words[i].ToCharArray().Reverse().ToArray());
                words[i] = word;
            }
        }
        return String.Join(" ", words);
        // Я бы написал так:
        //return string.Join(' ', sentence.Split(' ').Select(word =>
        // {
        //     if (word.Length > 4) return new string(word.Reverse().ToArray());
        //     else return word;
        // }));
    }
}