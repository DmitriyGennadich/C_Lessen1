//   Работа с текстом 
// дан текст. В тексте нужно все пробелы заменить черточки, 
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".


string text = " Перенесите Cвое хранилище в наш онлайн-инструмент или обеспечьте "
            + "максимальную конфиденциальность с помощью настольного приложения.";


// string s = "qwerty"
//             012
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'C', 'c');
Console.WriteLine(newText);
