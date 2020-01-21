using System;
using System.Collections.Generic;
using System.Text;

public class Head:Body
{
    int eyes;
    bool teeth;
    int maxHp;
    int hp;

    public Head()
    : base()
    {
        eyes = 2;
        teeth = true;
        hp = maxHp = 5;
    }
    public int HP { get { return hp; } set { hp = value; } }
    public int MaxHP { get { return maxHp; } set { maxHp = value; } }
    public int Eyes { get { return eyes; } set { eyes = value; } }
    public bool Teeth { get { return teeth; } set { teeth = value; } }
}