// метод который не принимает аргументы  и не возвращает ничего
void Method1()
{
    Console.WriteLine("Автор..");
}
Method1();

// метод который принимает аргументы  и не возвращает ничего
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");
Method2(msg:"Текст сообщения" ); // обращение к именованному аргументу

void Method21(string mesg, int cont)
{
    int i=0;
    while (i<cont)
    
    {
        Console.WriteLine(mesg);
        i++;
    }
}
Method21("привет",4);
Console.WriteLine();
Method21(mesg:"Как дела?", cont:4);// обращение к именованным аргументам
Console.WriteLine();
Method21(cont:4, mesg:"Что делаешь?");// послеовательность к обращении к именованным аргументам не имеет значения

// метод который не принимает аргументы  а  возвращает функцию
int Method3 () // результат работы переменная
{
    return DateTime.Now.Year;
}

int ye= Method3 ();
Console.WriteLine(ye);


// метод который н принимает аргументы  и  возвращает функцию
string Method4 (int count , string text) // результат работы строка
{
    int i=0;
    string result= String.Empty; //пустая строка
    while (i<count)
    
    {
        result= result+text;
        i++;
    }
    return result;
}
string res = Method4(10, " z ");
Console.WriteLine(res);
