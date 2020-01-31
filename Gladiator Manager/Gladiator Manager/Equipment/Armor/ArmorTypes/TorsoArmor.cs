﻿using System;
using System.Collections.Generic;
using System.Text;

public class TorsoArmor : Armor
{
    ArmArmor rightArmArmor; 
    ArmArmor leftArmArmor; 
    public TorsoArmor(int level, int tier)
    : base(level, tier)
    {
        rightArmArmor = new ArmArmor(level, tier);
        leftArmArmor = new ArmArmor(level, tier);
        HP = MaxHP = level + 1;
        name = $"{quality}{material}Chest";
    }
    public ArmArmor RightArmArmor { get { return rightArmArmor; } set { rightArmArmor = value; } }
    public ArmArmor LeftArmArmor { get { return leftArmArmor; } set { leftArmArmor = value; } }
}