using System;
using System.Collections.Generic;
using System.Text;

public class Blade : Weapon
{
    public Blade(int level, int tier)
    : base(level, tier)
    {
        damage = level + tier*2;
    }
    public override void Attack(Gladiator attacker, Gladiator defender)
    {
        if (attacker.Offence + Return.RandomInt(0, 3) > defender.Defence + Return.RandomInt(0, 3))
        {
            Body body = attacker.Target(defender, 9);
            int Damage = (attacker.Strength / 2) + attacker.Torso.RightArm.Hand.Weapon.Damage;
            body.TakeDamage(Damage);
            Console.WriteLine($"{attacker.Name} slashes {defender.Name} in the {body} for {Damage}");
        }
        else Console.WriteLine($"{attacker.Name}'s blow is turned aside by {defender.Name}");
    }
}