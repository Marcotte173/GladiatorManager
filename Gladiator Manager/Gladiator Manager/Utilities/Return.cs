using System;
using System.Collections.Generic;
using System.Text;

public class Return
{
    internal static Random rand = new Random();    
    internal static int RandomInt(int min, int max) { return rand.Next(min, max); }
}