using System;
using System.Collections.Generic;
using System.Text;

public class Hand : Body
{
    bool hook;
    bool dominant;
    Weapon weapon;
    HandArmor armor;
    public Hand(bool dominant)
    :base()
    {
        hp = maxHp = 5;
        armor = new HandArmor(0, 0);
        weapon = new Blade(1, 0);
    }
    public void Attack(Gladiator attacker, Gladiator defender) 
    {
        if (attacker.Offence + Return.RandomInt(0, 3) > defender.Defence + Return.RandomInt(0, 3))
        {
            Body body = Combat.Target(defender, 9);
            int Damage = (attacker.Strength / 2);
            body.TakeDamage(Damage);
            Console.WriteLine($"{attacker.Name} punches {defender.Name} in the {body} for {attacker.Strength / 2}");
        }
        else Console.WriteLine($"{attacker.Name}punches but {defender.Name} blocks!");
    }
    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);
    }
    public Weapon Weapon { get { return weapon; } set { weapon = value; } }
    public HandArmor Armor { get { return armor; } set { armor = value; } }
    public bool Hook { get { return hook; } set { hook = value; } }
    public bool Dominant { get { return dominant; } set { dominant = value; } }
}