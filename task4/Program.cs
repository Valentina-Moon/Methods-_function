// Работа с текстом 
// дан текстю В тексте нужно заменить все пробелы чертачками, 
// маленькие буква "к" заменить большими "К",
//большие "С" заменить маленькими "с".

string text = "-Я думаю, - сказал князь, улыбаюсь, -что,"
               + "ежели бы нас послали вместо нашего милого Виценгероде,"
               + "вы бы взяли приступом согласие прусского короля."
               + "Вы так красноречивый. Вы дадите мне чаю?";


//   string s ="qwerty"

// 012            
//s[3]// r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

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
newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'С', 'с');
Console.WriteLine(newText);