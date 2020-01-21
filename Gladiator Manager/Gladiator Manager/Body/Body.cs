using System;
using System.Collections.Generic;
using System.Text;

public class Body
{
    int maxHp;
    int hp;
    bool destroyed;

    public Body()
    {
        hp = maxHp = 5;        
    }
    public int HP { get { return hp; } set { hp = value; } }
    public int MaxHP { get { return maxHp; } set { maxHp = value; } }
    public bool Destroyed { get { return destroyed; } set { destroyed = value; } }
}