using System;
using System.Collections.Generic;
using System.Text;

public class Leg : Body
{
    bool peg;
    LegArmor armor;
    public Leg()
    : base()
    {
        hp = maxHp = 5;
        armor = new LegArmor(0, 0);
    }
    public LegArmor Armor { get { return armor; } set { armor = value; } }
    public bool Peg { get { return peg; } set { peg = value; } }
}