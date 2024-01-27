/*
Задача 2: Задайте строку, содержащую латинские буквы 
в обоих регистрах. Сформируйте строку, в которой все 
заглавные буквы заменены на строчные. 

“aBcD1ef!-” => “abcd1ef!-” 
*/

string GetStringToLower(string inString)
{
    string outString = inString.ToLower();
    return outString;
}

Console.Write("Введите строку: ");
string str = Console.ReadLine();
string res = GetStringToLower(str);
Console.WriteLine($"Результат - {res}");