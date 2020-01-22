using System;
using System.Collections.Generic;
using System.Text;

public class Head:Body
{
    int eyes;
    bool teeth;
    HeadArmor armor;

    public Head()
    : base()
    {
        eyes = 2;
        teeth = true;
        hp = maxHp = 5;
        armor = new HeadArmor(0, 0);
    }
    public HeadArmor Armor { get { return armor; } set { armor = value; } }
    public int Eyes { get { return eyes; } set { eyes = value; } }
    public bool Teeth { get { return teeth; } set { teeth = value; } }
}