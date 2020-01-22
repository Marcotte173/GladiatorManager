using System;
using System.Collections.Generic;
using System.Text;

public class Combat
{
    internal static void Calculate(Gladiator one, Gladiator two)
    {
        Console.SetCursorPosition(0, 20);
        Attack(one,two);
        Attack(two,one);
    }

    private static void Attack(Gladiator g, Gladiator p)
    {
        if (g.LeftHand.Destroyed == false && g.RightHand.Destroyed == false)
        {
            if (g.RightHanded) WeaponCheck(g.RightHand, g, p);
            else WeaponCheck(g.LeftHand, g, p);
        }        
        else if (g.LeftHand.Destroyed  && g.RightHand.Destroyed == false) WeaponCheck(g.RightHand, g, p);
        else if (g.LeftHand.Destroyed == false && g.RightHand.Destroyed) WeaponCheck(g.LeftHand, g, p);
        else if (g.LeftHand.Destroyed && g.RightHand.Destroyed) Console.WriteLine(g.Name + " cannot attack without arms. He waits for death");
    }

    private static void WeaponCheck(Hand hand, Gladiator g, Gladiator p)
    {
        if (hand.Weapon.Level != 0) hand.Weapon.Attack(g, p);
        else hand.Attack(g, p);
    }

    internal static void Damage(Body g, int damage)
    {
        g.HP -= damage;
        g.CheckStatus();
    }

    internal static Body Target(Gladiator g, int y)
    {
        int x = Return.RandomInt(0, y);
        if (x == 0) return g.LeftLeg;
        else if (x == 1) return g.Head;
        else if (x == 2) return g.RightArm;
        else if (x == 3) return g.RightHand;
        else if (x == 4) return g.LeftArm;
        else if (x == 5) return g.LeftHand;
        else if (x == 6) return g.RightLeg;
        else return g.Torso;
    }
}