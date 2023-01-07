// Вид 1 (не принимают и не возвращают)

void Method1()
{
    Console.WriteLine("Автор ...");
}
// Method1();
// Method1 - без скобок не правильно


// Вид 2 (принимают и не возвращают)

void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i ++;
    }
}
// Method21("ТЕКСТ", 4); // "телол сообщения", 4 - сколько раз показать.
// Method21(count: 4, msg: "новый текст");


// Вид 3 (не принимают, но возвращают)

int Method3()
{
    return DateTime.Now.Year; // с возвращаемыми методами обязательно использовать "return"
}
int year = Method3();
// Console.WriteLine(year);


// Вид 4 (принимают и возвращают)

/* string Method4(int count, string text) // в конце ";" не нужны
{
    int i = 0;
    string result = string.Empty;

    while ( i < count)
    {
        result = result + text;
        i ++;
    }
    return result;
}
*/

string Method4(int count, string text) // c использованием цикла for
{
    string result = string.Empty;
    for( int i = 0; i < count; i ++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "мир ");
// Console.WriteLine(res);


// Цикл в цикле

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
//        Console.WriteLine($"{i} x {j} = {i * j}");
    }
//    Console.WriteLine(); //переход н ановую строку
}




//====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

// Ясна ли задача?

string text = "-Я думаю, - сказал князь, улыбаясь, - что,"
            + "ежели бы вас послали вместо нашего милого Винцегероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012
// s[3] // r

Console.Clear();
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');

Console.WriteLine(newText);
Console.WriteLine(); // строка для отделения вариантов текстов
newText = Replace(newText, 'к', 'К'); // replace NEWtext, а не просто text, потому что мы в измененный текст еще вносим изменения
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);