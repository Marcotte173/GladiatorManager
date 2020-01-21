using System;
using System.Collections.Generic;
using System.Text;

public class Arm:Body
{
    bool bladeArm;
    int maxHp;
    int hp;
    public Arm()
    : base()
    {
        hp = maxHp = 5;
    }
    public int HP { get { return hp; } set { hp = value; } }
    public int MaxHP { get { return maxHp; } set { maxHp = value; } }
    public bool BladeArm { get { return bladeArm; } set { bladeArm = value; } }
}