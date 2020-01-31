using System;
using System.Collections.Generic;
using System.Text;

public class ArmArmor : Armor
{
    public ArmArmor(int level, int tier)
    : base(level, tier)
    {
        HP = MaxHP = 2 + level;
        name =$"{quality}{material}Vambraces" ;
    }
}