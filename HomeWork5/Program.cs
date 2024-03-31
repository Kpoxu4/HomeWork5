using HomeWork5;
using System.Text;

Console.OutputEncoding = System.Text.Encoding.UTF8;
StringBuilder text = new StringBuilder();
string itemStartMenu;
string path;
// Стартовое меню
while (true)
{
    Console.Clear();
    Console.WriteLine("""
        Программа работы с текстом:
        1. - Набор текста.
        2. - Путь к файлу.
        3. - Выход
        """);
    itemStartMenu = Console.ReadLine();
    if (itemStartMenu == "1")
        break;
    else if (itemStartMenu == "2")
        break;
    else if (itemStartMenu == "3")
        Environment.Exit(0);
    else
    {
        Console.WriteLine("Выберите пункт меню");
        Console.ReadKey();
    }
}
// Меню набора текста
if (itemStartMenu == "1")
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine("Ведите любой текст");
        var str = Console.ReadLine();
        if (String.IsNullOrWhiteSpace(str))
            continue;
        else
        {
            text.Append(str);
            break;
        }
    }
}
// Меню набора пути к файлу
if (itemStartMenu == "2")
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine("Введите путь к текстовому файлу");
        path = Console.ReadLine();
        try
        {
            StreamReader sr = new StreamReader(path);
            text.Append(sr.ReadToEnd());
            if (text.ToString() == "")
            {
                Console.WriteLine("файл пуст");
                ProgramInfo.MiniMenuInfo();
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                    Environment.Exit(0);
            }
            else
                break;
        }
        catch (Exception e)
        {
            Console.WriteLine("Ошибка прочтения файла или не верный путь: " + e.Message);
            ProgramInfo.MiniMenuInfo();
            if (Console.ReadKey().Key == ConsoleKey.Escape)
                Environment.Exit(0);
        }
    }
}

// Меню действия над текстом
while (true)
{
    Console.Clear();
    Console.WriteLine(text.ToString());
    ProgramInfo.MenuInfo();
    var itemMenu = Console.ReadLine();
    if (itemMenu != null && MenuItem.CheckingMenuItem(itemMenu))
    {
        var result = MenuItem.SelectingMenuItem(itemMenu, text.ToString());
        if (result == "Выход")
            Environment.Exit(0);
        Console.WriteLine();
        Console.WriteLine(result);
        Console.WriteLine();
        ProgramInfo.MiniMenuInfo();
        if (Console.ReadKey().Key == ConsoleKey.Escape)
            Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("Неверный пункт меню");
    }
}
Console.ReadLine();