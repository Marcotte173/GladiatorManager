using System;
using System.Collections.Generic;
using System.Text;

public class Write
{
    internal static void Line(int x, int y, string words) { Console.SetCursorPosition(x, y); Console.Write(words); }
    internal static void Line(string words) { Console.Write(words); }
    internal static void Character(int x, int y, string word1,string word2, string word3, string word4) { Console.SetCursorPosition(x, y);  Console.Write(word1); Console.SetCursorPosition(x + 15, y); Console.Write(word2); Console.SetCursorPosition(x + 27, y); Console.Write(word3); Console.SetCursorPosition(x + 40, y); Console.Write(word4); }
}