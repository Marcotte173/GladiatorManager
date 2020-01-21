using System;
using System.Collections.Generic;
using System.Text;

public class Leg : Body
{
    bool peg;
    int maxHp;
    int hp;
    public Leg()
    : base()
    {
        hp = maxHp = 5;
    }
    public int HP { get { return hp; } set { hp = value; } }
    public int MaxHP { get { return maxHp; } set { maxHp = value; } }
    public bool Peg { get { return peg; } set { peg = value; } }
}