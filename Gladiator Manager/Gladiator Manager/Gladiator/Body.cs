using System;
using System.Collections.Generic;
using System.Text;

public class Body
{
    protected int maxHp;
    protected int hp;
    protected bool destroyed;

    public Body()
    {
       
    }
    public int HP { get { return hp; } set { hp = value; } }
    public int MaxHP { get { return maxHp; } set { maxHp = value; } }
    public bool Destroyed { get { return destroyed; } set { destroyed = value; } }
    public void CheckStatus() { destroyed = (hp <= 0) ? true : false; }
    public string Status { get { return (hp == maxHp) ? Colour.HEALTH + "Undamaged" + Colour.RESET : (hp <= 0) ? Colour.DAMAGE + "Destroyed" + Colour.RESET : (hp < maxHp && (hp == 1 && hp == 2)) ? Colour.GOLD + "Severely Damaged" + Colour.RESET : Colour.HIT + "Damaged" + Colour.RESET; }}
}