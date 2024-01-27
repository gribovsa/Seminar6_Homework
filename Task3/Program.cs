/*
Задача 3: Задайте произвольную строку. Выясните, 
является ли она пoлиндромом.

“aBcD1ef!-” => Нет
“шалаш” => Да
“55655” => Да

*/



char[] StringToArray(string str) //метод превращает строку в массив
{
    char[] arr = str.ToCharArray();
    return arr;
}


char[] ArrayRevers(char[] arr) //метод переворачивает массив
{
    //char[] array = { 'a', 'b', 'c', 'd' };
    Array.Reverse(arr);
    return arr;
}


string ArrayToString(char[] arr) //метод превращает массив в строку
{
    string str = "";
    foreach (char e in arr)
    {
        str = str + e;
    }
    return str;

}

Console.Write("Введите строку: ");
string inputStr = Console.ReadLine();
char[] array = StringToArray(inputStr); //строку в макссив
char[] revArr = ArrayRevers(array); //переворот массива
string outStr = ArrayToString(revArr); //массив в строку
if (inputStr == outStr)
{
    Console.Write($" Да!, {inputStr} - является полиндромом");
}
else
{
    Console.Write($" Нет, {inputStr} - не является полиндромом");
}

