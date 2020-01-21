using System;
using System.Collections.Generic;
using System.Text;

public class Leg : Body
{
    bool peg;
    public Leg()
    : base()
    {
        hp = maxHp = 5;
    }
    public bool Peg { get { return peg; } set { peg = value; } }
}