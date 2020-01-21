using System;
using System.Collections.Generic;
using System.Text;

public class HandArmor : Armor
{
    public HandArmor(int level, int tier)
    : base(level, tier)
    {
        HP = MaxHP = 2 + level;
    }
}