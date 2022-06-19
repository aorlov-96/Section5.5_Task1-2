namespace task1_2
{
    class Program
    {
        static void Main()
        {

            static string ReversWords(string inputPhrase) // метод переворота текста наооборот
            {
                string[] textResult = WordSentenceSeparator(inputPhrase);// делю предложение на слова
                Array.Reverse(textResult); // переворачиваю массив, получаю слова в обратном порядке
                string newString; 
                string resultString = textResult[0] + " "; // присваиваю переменной первое слова перевернутого массива + пробел
                for (int i = 1; i < textResult.Length; i++) // цикл сложения слов в предложение
                {
                    newString = textResult[i]; // присваиваю переменной слово из массива 
                    resultString += newString + " "; // собираю предложение + пробел
                }
                
                return resultString;

            }


            static string[] WordSentenceSeparator(string text) // метод деления предложения на слова.
            {
                char[] separators = new char[] { ' ', '.' }; // символы для исключения 
                string[] separatorWords = text.Split(separators, StringSplitOptions.RemoveEmptyEntries); //собираю массив слов
                return separatorWords;
            }

            Console.WriteLine("Введите предложение");
            string sentence = Console.ReadLine();
            sentence = ReversWords(sentence);
            Console.WriteLine(sentence);
            
            




        }
    }
}




