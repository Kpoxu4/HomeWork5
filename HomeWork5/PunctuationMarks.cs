using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    /// <summary>
    /// Класс поля readonly знаков препинание.
    /// </summary>
    public record PunctuationMarks ()
    {
        /// <summary>
        /// Поле всех знаков препинания.
        /// </summary>
        public readonly string[] arrayAllPunctuationMarks = new string[]
        {
            ".", ",", ";", "...", ":", "?", "!", "-", "[", "]", "(", ")", "<", ">",
            "\'", "\"", " "
        };
        //public readonly string[] arrayOfLineEndings = new string[] { "?", "!", "." };

    }
}
