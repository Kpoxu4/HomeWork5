using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HomeWork5
{
    /// <summary>
    /// Класс работы со сроками
    /// </summary>
    public static class WorkingWithStrings
    {
        /// <summary>
        /// Вывод предложений без запятых.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string FindSentencesWithoutCommas(string text)
        {
            StringBuilder sb = new StringBuilder();
            string[] arrayStrings1 = FindRegularExpressions(text, @"[\w\,\.\d\s]*\?");
            string[] arrayStrings2 = FindRegularExpressions(text, @"[\w\,\.\d\s]*\!");
            string[] arrayStrings3 = FindRegularExpressions(text, @"[\w\,\.\d\s]*\.");

            List<string> list = new List<string>();
            foreach (string s in arrayStrings1)
                list.Add(s);
            foreach (string s in arrayStrings2)
                list.Add(s);
            foreach (string s in arrayStrings3)
                list.Add(s);

            foreach (string str in list)
            {
                if(!str.Contains(','))
                    sb.Append(str.Trim() + "\n");
            }
            return sb.ToString();
        }
        /// <summary>
        /// Поиск вопросительных  а затем восклицательных предложений
        /// </summary>
        public static string SearchForInterrogativeSentences(string text)
        {
            var matches1 = Regex.Matches(text, @"[\w\,\s]*\?");
            var matches2 = Regex.Matches(text, @"[\w\,\s]*\!");
            string[] arrayStrings1 = matches1.Cast<Match>().Select(m => m.Value).ToArray();
            string[] arrayStrings2 = matches2.Cast<Match>().Select(m => m.Value).ToArray();
            int count = arrayStrings1.Length + arrayStrings2.Length;

            return $"Количество предложений {count}:\n{String.Join('\n', arrayStrings1)}\n{String.Join('\n', arrayStrings2)}";
        }
        /// <summary>
    /// Замена всех цифр на слова.
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
        public static string ReplacingNumberWithWord(string text)
        {
            foreach (char item in text)
            {
                if (char.IsDigit(item)) 
                {
                    text = text.Replace(item.ToString(), ReplacingNumberWithWord(item));
                }
                   
            }
            return text;
        }
        /// <summary>
        /// Ищет слова, содержащие максимальное количество цифр.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string FindWordsThatMaxQuantityNumbers(string text)
        {
            string[] strings = WordsWithNumber(text).Split(" ").Where(x => x != null && x != "").ToArray();
            int count = 0;
            int helpCount = 0;
            StringBuilder sb = new StringBuilder();
            foreach (string word in strings)
            {
                foreach(char item in word)
                {
                    if(char.IsDigit(item))
                    {
                        helpCount++;
                    }
                }
                if (helpCount > count)
                {
                    count = helpCount;
                    helpCount = 0;
                    sb.Clear();
                    sb.Append(word);
                }
                if (helpCount == count)
                {
                    helpCount = 0;
                    sb.Append("\n" + word);
                }
                helpCount = 0;
            }
            return $"Слова содержащие максимальное количество цифр:\n{sb.ToString()}";
        }
        /// <summary>
        /// Ищет слово, начинающиеся и заканчивающиеся на одну и ту же букву.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string FindWordsThatStartAndEndEqual(string text)
        {
            StringBuilder sb = new StringBuilder();
            var arrayString = ArrayString(text);
            foreach ( var item in arrayString )
            {
                if (item[0] == item[item.Length - 1] && !Char.IsDigit(item[0]))
                    sb.Append(item + "\n");
            }
            return $"Слова которые начинаются и заканчиваются одинаковой буквой:\n{sb.ToString()}";
        }
        /// <summary>
        /// Ищет количество повторений длинного слова.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string FindQuantityLongsWord(string text)
        {
            var arrayString = ArrayString(text);
            int count = arrayString.Where(x => x == FindTheLongsWord(text)).Count();

            return $"Самое длинное слово: \"{FindTheLongsWord(text)}\" количество повторений: {count}";
        }
        /// <summary>
        /// Ищет самое длинное слово.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private  static string FindTheLongsWord(string text) 
        {
            string longWord = "";
            int max = 0;
            var arrayString = ArrayString(text);
            foreach (var word in arrayString)
            {
                if (word.Length > max)
                {
                    max = word.Length;
                    longWord = word;
                } 
            }
            return longWord;
        }
        /// <summary>
        /// Создает массив слов из любого текста
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private static string[] ArrayString(string text)
        {
            PunctuationMarks punctuationMarks = new PunctuationMarks();
            var punctuation = punctuationMarks.arrayAllPunctuationMarks;
            var arrayString = text.Split(punctuation, StringSplitOptions.RemoveEmptyEntries).ToArray();
            return arrayString;
        }
        /// <summary>
        /// Ищет цифры в словах.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private static string WordsWithNumber(string text)
        {
            string result = "";
            var arrayString = ArrayString(text);
            foreach(var word in arrayString)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (Char.IsDigit(word[i]))
                    {
                        result += word + " ";
                        break;
                    }
                }
            }
            return result;
        }
        /// <summary>
        /// Меняет цифры на слова.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        private static string ReplacingNumberWithWord(char item)
        {
            switch (item) 
            {
                case '0':
                    return "ноль ";
                case '1':
                    return "один ";
                case '2':
                    return "два ";
                case '3':
                    return "три ";
                case '4':
                    return "четыре ";
                case '5':
                    return "пять ";
                case '6':
                    return "шесть ";
                case '7':
                    return "семь ";
                case '8':
                    return "восемь ";
                case '9':
                    return "девять ";
                default:
                    return "";
            }   
        }
        /// <summary>
        /// Поиск регулярных выражений
        /// </summary>
        /// <param name="text"></param>
        /// <param name="regular"></param>
        /// <returns></returns>
        private static string[] FindRegularExpressions(string text, string regular)
        {
            var matches = Regex.Matches(text, regular);
            return matches.Cast<Match>().Select(m => m.Value).ToArray();
        }
    }
}
