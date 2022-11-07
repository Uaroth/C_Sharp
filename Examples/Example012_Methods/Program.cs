// ВИД 1 Не принимает, не возвращает
void Method1()
{
    Console.WriteLine("Автор - Варот");
}
// Вызывать через Method1();




// ВИД 2 Принимают, но не возвращают
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21("Текст", 4);
// Method21(count: 4, msg: "Текст");




// ВИД 3 Не принимает, но возвращает

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);




// ВИД 4 Принимает и возвращает

//string Method4(int count, string text)
//{
//    int i = 0;
//    string result = String.Empty;
//    while (i < count)
//    {
//        result = result + text;
//        i++;
//    }
//    return result;
//}
//string res = Method4(10, "asdf");
//Console.WriteLine(res);





string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "z");
// Console.WriteLine(res);

// for (int i = 2; i < 11; i++)
// {
//     for (int j = 2; j < 11; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }


string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";


// string s = "qwerty"
//             0123
// s{3} // r

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

string newText = Replace(text, " ", "|");
Console.WriteLine(newText);