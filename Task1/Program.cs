﻿/*
Задача 1: Задайте двумерный массив символов (тип char 
[,]). Создать строку из символов этого массива. 

a b c => “abcdef”
d e f 

*/

string GetStringFrmChar(char[,] array)
{
    string str = "";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            str = str + array[i, j];
    }

    return str;
}

char[,] str = new char[,]
           {
                {'a', 'b', 'c', 'd'},
                {'e', 'f', 'g', 'h'},
                {'i', 'j', 'k', 'l'},
           };
string res = GetStringFrmChar(str);
Console.WriteLine(res);