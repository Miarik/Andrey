Console.WriteLine("Таблица умножения");

string text = "Какое Сегодня красивое утро";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;

    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue){
            result = result + $"{newValue}";
        }
        else{
            result = result + $"{text[i]}";
        }
    }

    return result;
}

string newText = Replace(text, ' ', '-');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'К', 'к');
Console.WriteLine(newText);