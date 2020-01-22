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
        if (g.Torso.LeftArm.Hand.Destroyed == false && g.Torso.RightArm.Hand.Destroyed == false)
        {
            if (g.RightHanded) WeaponCheck(g.Torso.RightArm.Hand, g, p);
            else WeaponCheck(g.Torso.LeftArm.Hand, g, p);
        }        
        else if (g.Torso.LeftArm.Hand.Destroyed  && g.Torso.RightArm.Hand.Destroyed == false) WeaponCheck(g.Torso.RightArm.Hand, g, p);
        else if (g.Torso.LeftArm.Hand.Destroyed == false && g.Torso.RightArm.Hand.Destroyed) WeaponCheck(g.Torso.LeftArm.Hand, g, p);
        else if (g.Torso.LeftArm.Hand.Destroyed && g.Torso.RightArm.Hand.Destroyed) Console.WriteLine(g.Name + " cannot attack without arms. He waits for death");
    }

    private static void WeaponCheck(Hand hand, Gladiator g, Gladiator p)
    {
        if (hand.Weapon.Level != 0) hand.Weapon.Attack(g, p);
        else hand.Attack(g, p);
    }

    internal static Body Target(Gladiator g, int y)
    {
        int x = Return.RandomInt(0, y);
        if (x == 0) return g.Torso.LeftLeg;
        else if (x == 1) return g.Torso.Head;
        else if (x == 2) return g.Torso.RightArm;
        else if (x == 3) return g.Torso.RightArm.Hand;
        else if (x == 4) return g.Torso.LeftArm;
        else if (x == 5) return g.Torso.LeftArm.Hand;
        else if (x == 6) return g.Torso.RightLeg;
        else return g.Torso;
    }
}