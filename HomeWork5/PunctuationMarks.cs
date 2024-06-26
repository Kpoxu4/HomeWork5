﻿namespace HomeWork5
{
    /// <summary>
    /// Класс поля readonly знаков препинание.
    /// </summary>
    public record PunctuationMarks()
    {
        /// <summary>
        /// Поле всех знаков препинания.
        /// </summary>
        public readonly string[] arrayAllPunctuationMarks = new string[]
        {
            ".", ",", ";", "...", ":", "?", "!", "-", "[", "]", "(", ")", "<", ">",
            "\'", "\"", " "
        };
        public readonly char[] arrayFinishPunctuationMarks = new char[]
        {
            '.', '!', '?',
        };

    }
}
