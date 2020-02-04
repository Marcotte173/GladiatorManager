using System;
using System.Collections.Generic;
using System.Text;

public class Return
{
    internal static Random rand = new Random();    
    internal static int RandomInt(int min, int max) { return rand.Next(min, max); }

    internal static bool Afford(int price)
    {
        return Player.p.Gold >= price;
    }
    internal static int Integer()
    {
        int sellChoice;
        do
        {

        } while (!int.TryParse(Console.ReadLine(), out sellChoice));
        return sellChoice;
    }
    internal static int Int()
    {
        int sellChoice;
        do
        {

        } while (!int.TryParse(Console.ReadKey(true).KeyChar.ToString().ToLower(), out sellChoice));
        return sellChoice;
    }
    internal static string Option()
    {
        return Console.ReadKey(true).KeyChar.ToString().ToLower();
    }


    internal static void ToHub() { Location.list[0].Go(); }
}