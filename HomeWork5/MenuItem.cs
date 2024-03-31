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
        public static string SelectingMenuItem(string item, string text)
        {
            switch (item)
            {
                case "1":
                    return text.FindWordsThatMaxQuantityNumbers();
                case "2":
                    return text.FindQuantityLongsWord();
                case "3":
                    return text.ReplacingNumberWithWord();
                case "4":
                    return text.SearchForInterrogativeSentences();
                case "5":
                    return text.FindSentencesWithoutCommas();
                case "6":
                    return text.FindWordsThatStartAndEndEqual();
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
