// цикл for
string Method5 (int count , string text) // результат работы строка
{
    
    string result= String.Empty; //пустая строка
    for (int i=0; i<count; i++)    
    {
        result= result+text;       
    }
    return result;
}
string res = Method5(10, " z ");
Console.WriteLine(res);

// for (int i=1; i<=10; i++) // таблица умножения
// {
//     for (int j=1; j<=10; j++)
//     {
//         Console.WriteLine($"{i}x{j}={i*j}");
//     }
//     Console.WriteLine();
    
// } 

// Работа с текстом
//Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими"с".

string text ="- я думаю,- сказал князь, улыбаясь, -что,"
            +"ежели бы вас послали вместо нашего милого Винценгероде,"
            +"вы бы взяли приступом согласие прусского короля."
            +"Вы так красноречивы . Вы дадите мне чаю?";
//string s ="qwerty"
//           012
//s[3]=r
string Rep(string text, char oldValue, char newValue)
{
    string result=String.Empty;

    int lenght = text.Length; //количество символов в тексте
    for(int i=0; i<lenght; i++)
    {
        if (text[i]==oldValue) result = result+ $"{newValue}";
        else result = result+ $"{text[i]}";
    }
    return result;
}
string luboytext= Rep(text, ' ', '|'); // внимание одинарные кавычки
Console.WriteLine(luboytext);
Console.WriteLine();
string vtoroytext= Rep(text, 'к', 'К'); // внимание одинарные кавычки
Console.WriteLine(vtoroytext);

// сортировка массива
int []arr = {1, 2, 3, 4, 8 , 6, 4, 7, 3, 9, 5}; //например такой массив

void Printarray(int []array)
{
    int count =array.Length;
    for (int i=0; i<count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    
}

void SelectSort(int []array)
{
    
    for (int i=0; i<array.Length-1; i++)
    {
        int minPosition = i;
        for (int j=i+1; j<array.Length; j++)
        {
            if (array[j]< array[minPosition] ) minPosition = j;
        }

        int temporary= array[i];      // замена значения через временную переменную
        array[i]=array[minPosition];
        array[minPosition]=temporary;
        
    }
}

Printarray(arr);
SelectSort(arr);
Printarray(arr);
