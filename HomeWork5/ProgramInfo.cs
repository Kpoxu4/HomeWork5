using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5 
{ 
    /// <summary>
    /// Класс информации для программы.
    /// </summary>
    public static class ProgramInfo
    {
        public static void MenuInfo()
        {
            Console.WriteLine("""


                1. - Найти слова, содержащие максимальное количество цифр.
                2. - Найти самое длинное слово и определить, сколько раз оно встретилось в тексте.
                3. - Заменить цифры от 0 до 9 на слова «ноль», «один», ..., «девять».
                4. - Вывести на экран сначала вопросительные, а затем восклицательные предложения.
                5. - Вывести на экран только предложения, не содержащие запятых.
                6. - Найти слова, начинающиеся и заканчивающиеся на одну и ту же букву.
                7. - Выход.
                """);   
        }
        public static void MiniMenuInfo(string menuInfo = "Для продолжения нажмите любую кнопку.\nВыход нажмите ESC")
        {
              Console.WriteLine(menuInfo);
        }
    }
}
