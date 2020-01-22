using System;
using System.Collections.Generic;
using System.Text;

public class Arm:Body
{
    bool bladeArm;
    ArmArmor armor;
    public Arm()
    : base()
    {
        hp = maxHp = 5;
        armor = new ArmArmor(0, 0);
    }
    public ArmArmor Armor { get { return armor; } set { armor = value; } }
    public bool BladeArm { get { return bladeArm; } set { bladeArm = value; } }
}