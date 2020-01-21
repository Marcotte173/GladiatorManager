using System;
using System.Collections.Generic;
using System.Text;

public class Arm:Body
{
    bool bladeArm;
    public Arm()
    : base()
    {
        hp = maxHp = 5;
    }
    public bool BladeArm { get { return bladeArm; } set { bladeArm = value; } }
}