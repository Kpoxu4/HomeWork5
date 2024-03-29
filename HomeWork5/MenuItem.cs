using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    /// <summary>
    /// Класс перебора меню.
    /// </summary>
    public static class MenuItem
    {
        /// <summary>
        /// Выбор пункта меню.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string SelectingMenuItem(string item ,string text) 
        {
            switch (item)
            {
                case "1":
                    return WorkingWithStrings.FindWordsThatMaxQuantityNumbers(text);
                case "2":
                    return WorkingWithStrings.FindQuantityLongsWord(text);
                case "3":
                    return WorkingWithStrings.ReplacingNumberWithWord(text);
                case "4":
                    return WorkingWithStrings.SearchForInterrogativeSentences(text);
                case "5":
                    return WorkingWithStrings.FindSentencesWithoutCommas(text);
                case "6":
                    return WorkingWithStrings.FindWordsThatStartAndEndEqual(text);
                case "7":
                    return "Выход";
                default:
                    return "";
            }
        }
        /// <summary>
        /// Проверка ввода пункта меню.
        /// </summary>
        /// <param name="itemMenu"></param>
        /// <returns></returns>
        public static bool CheckingMenuItem(string itemMenu)
        {
            switch (itemMenu)
            {
                case "1":
                    return true;
                case "2":
                    return true;
                case "3":
                    return true;
                case "4":
                    return true;
                case "5":
                    return true;
                case "6":
                    return true;
                case "7":
                    return true;
                default: 
                    return false;
            }
        }
    }
}
