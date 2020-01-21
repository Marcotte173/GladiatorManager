using System;
using System.Collections.Generic;
using System.Text;

public class Hand : Body
{
    bool hook;
    public Hand()
    :base()
    {
        hp = maxHp = 5;
    }
    public bool Hook { get { return hook; } set { hook = value; } }
}