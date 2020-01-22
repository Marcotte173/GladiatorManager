using System;
using System.Collections.Generic;
using System.Text;

public class Torso : Body
{
    TorsoArmor armor;
    public Torso()
    : base()
    {
        hp = maxHp = 5;
        armor = new TorsoArmor(0, 0);
    }
    public TorsoArmor Armor { get { return armor; } set { armor = value; } }
}