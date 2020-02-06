using System;
using System.Collections.Generic;
using System.Text;

public class Blade : Weapon
{
    public Blade(int level, int tier)
    : base(level, tier)
    {
        damage = 2 + (level + tier*2);
        if (level == 0) name = "Fist";
    }
}