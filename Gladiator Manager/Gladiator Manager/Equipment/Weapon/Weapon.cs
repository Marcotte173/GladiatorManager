using System;
using System.Collections.Generic;
using System.Text;

public class Weapon:Equipment
{
    protected int damage;
    public Weapon(int level, int tier)
    : base(level, tier)
    {

    }
    public virtual void Attack(Gladiator attacker, Gladiator defender)
    {


    }
    public int Damage { get { return damage; } set { damage = value; } }
}