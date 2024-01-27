/*
Задача 4*(не обязательная): Задайте строку, состоящую 
из слов, разделенных пробелами. Сформировать строку, 
в которой слова расположены в обратном порядке. В 
полученной строке слова должны быть также разделены 
пробелами.

“Hello my world” => “world my Hello”

*/


string[] StringToArray(string str) //метод превращает строку в массив строк
{
        string[] arr = str.Split(" ");
        return arr;
}


string[] ArrayRevers(string[] arr) //метод переворачивает массив
{
        Array.Reverse(arr);
        return arr;
}


string ArrayToString(string[] arr) //метод превращает массив в строку
{
        string str = String.Join(" ", arr);
        return str;
}
Console.Write("Введите строку: ");
string inputStr = Console.ReadLine();
string[] array = StringToArray(inputStr); //строку в массив строк
string[] revArr = ArrayRevers(array); //переворот массива
string outStr = ArrayToString(revArr); //массив в строку
Console.Write(outStr);