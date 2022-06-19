using System;

namespace task1_2
{
    class Program
    {
        static void Main()
        {
            static string[] WordSentenceSeparator(string text) // метод деления предложения на слова.
            {
                char[] separators = new char[] { ' ', '.' };
                string[] separatorWords = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                OutputtingWordsSeparation(separatorWords);
                return separatorWords;
            }
            static string[] OutputtingWordsSeparation(string[] words) // метод вывода полученого массива
            {
                Console.WriteLine("Полученный массив:");
                for (int i = 0; i < words.Length; i++)
                {
                    Console.WriteLine(words[i]);
                }
                return words;

            }


            Console.WriteLine("Введите предложение");
            string sentence = Console.ReadLine();
            WordSentenceSeparator(sentence); 




        }

    }



}