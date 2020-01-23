using System;
using System.Collections.Generic;
using System.Text;

public class Write
{
    internal static void StringPosition(int x, int y, string words) { Console.SetCursorPosition(x, y); Console.Write(words); }
    internal static void Character(int x, int y, string word1,string word2, string word3) { Console.SetCursorPosition(x, y);  Console.Write(word1); Console.SetCursorPosition(x + 15, y); Console.Write(word2); Console.SetCursorPosition(x + 25, y); Console.Write(word3); }
}