using System;
using System.Collections.Generic;
using System.Text;

public class Armor:Equipment
{
    int maxHp;
    int hp;
    int fatigue;
    int encumbrance;
    public Armor(int level, int tier)
    : base(level,tier)
    {

    }
    public int HP { get { return hp; } set { hp = value; } }
    public int MaxHP { get { return maxHp; } set { maxHp = value; } }
    public int Fatigue { get { return hp; } set { hp = value; } }
    public int Encumbrance { get { return encumbrance; } set { encumbrance = value; } }
}