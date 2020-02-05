using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;

public class Arena:Location
{
    internal static Gladiator Gladiator1 = new Gladiator(2);
    internal static Gladiator Gladiator2 = new Gladiator(2);
    static bool player;
    public Arena()
    :base()
    {
        
    }
    public override void Menu()
    {
        if (Gladiator1.Owner == Player.p || Gladiator2.Owner == Player.p) player = true;
        else player = false;
        Fight();
        
    }
    private void Fight()
    {
        for (int i = 0; i < 10; i++)
        {
            if (player)
            {
                Console.Clear();
                UI();
                Console.SetCursorPosition(0, 22);
            }
            Attack();
            if (Gladiator1.DeathCheck())
            {
                if (player) Write.Line($"{Gladiator2.Name} has killed {Gladiator1.Name}");
                foreach (Gladiator g in Gladiator1.Owner.Roster)
                {
                    if (g == Gladiator1) Gladiator1 = null;
                }                
                break;
            }
            if (Gladiator2.DeathCheck())
            {
                if (player) Write.Line($"{Gladiator1.Name} has killed {Gladiator2.Name}");
                foreach (Gladiator g in Gladiator2.Owner.Roster)
                {
                    if (g == Gladiator2) Gladiator2 = null;
                }                
                break;
            }
            Thread.Sleep(1000);
        }
        Write.KeyPress();
        if (Gladiator1.DeathCheck() == false && Gladiator1.DeathCheck() == false) Fight();
    }

    private void Attack()
    {
        int attackRoll = Return.RandomInt(1, 101);
        attackRoll -= (Gladiator1.Torso.RightArm.Hand.Weapon.Level < 1) ? 0 : Gladiator1.Torso.RightArm.Hand.Weapon.Level;
        attackRoll -= Gladiator1.Offence;
        attackRoll += (Gladiator2.Torso.RightArm.Hand.Weapon.Level < 1) ? 0 : Gladiator2.Torso.RightArm.Hand.Weapon.Level;
        attackRoll += Gladiator2.Offence;
        int x = (Gladiator2.Torso.LeftArm.Hand.Weapon.Type == "Shield") ? Gladiator2.Torso.LeftArm.Hand.Weapon.Damage : 0;
        int y = (Gladiator1.Torso.LeftArm.Hand.Weapon.Type == "Shield") ? Gladiator1.Torso.LeftArm.Hand.Weapon.Damage : 0;
        if (attackRoll < (45 - Gladiator2.Defence - x))
        {
            //Gladiator1 strikes
            int damage = Gladiator1.Torso.RightArm.Hand.Weapon.Damage + Gladiator1.Torso.LeftArm.Hand.Weapon.Damage;
            Body body = Target(Gladiator2);
            body.TakeDamage(damage);
            if (player) Write.Line($"{Gladiator1.Name} strikes {Gladiator2.Name} for {damage} damage");
        }
        else if (attackRoll > (55 + Gladiator1.Defence + y))
        {
            //Gladiator2 strikes
            int damage = Gladiator2.Torso.RightArm.Hand.Weapon.Damage + Gladiator2.Torso.LeftArm.Hand.Weapon.Damage;
            Body body = Target(Gladiator1);
            body.TakeDamage(damage);
            Write.Line($"The gladiators square off, neither gaining a real advantage");
            if (player) Write.Line($"{Gladiator2.Name} strikes {Gladiator1.Name} for {damage} damage");
        }
        else
        {
            if (player) Write.Line("The gladiators square off, neither gaining a real advantage");
        }
    }
    internal Body Target(Gladiator g)
    {
        int x = Return.RandomInt(0, 12);
        if (x == 0) return g.Torso.Head;
        else if (x == 1||x==2) return g.Torso.RightArm;
        else if (x == 3) return g.Torso.RightArm.Hand;
        else if (x == 4||x==5) return g.Torso.LeftArm;
        else if (x == 6) return g.Torso.LeftArm.Hand;
        else if (x == 7) return g.Torso.LeftLeg;
        else if (x == 8) return g.Torso.RightLeg;
        else return g.Torso;
    }

    public static void Fight(Gladiator a, Gladiator b)
    {
        Gladiator1 = a;
        Gladiator2 = b;
        Location.list[2].Go();
    }    

    private static void UI()
    {
        Display(0, Gladiator1);
        for (int i = 0; i < 120; i++)
        {
            Write.Line(i, 10, "-");
            Write.Line(i, 20, "-");
        }
        for (int i = 0; i < 20; i++)
        {
            Write.Line(58, i, Colour.MITIGATION + "|" + Colour.RESET);
            Write.Line(59, i, Colour.MITIGATION + "|" + Colour.RESET);
        }
        Write.Line(58, 20, "+");
        Write.Line(59, 20, "+");
        Display(60, Gladiator2);
    }

    private static void Display(int x, Gladiator g)
    {
        Write.Character(x, 0, g.Name, "", "");
        Write.Line(x, 2, $"Strength    {g.Strength}");
        Write.Line(x, 3, $"Offence     {g.Offence}");
        Write.Line(x, 4, $"Defence     {g.Defence}");
        Write.Line(x, 5, $"Endurance   {g.Endurance}");
        Write.Line(x, 6, $"Initiative  {g.Initiative}");
        Write.Line(x + 15, 0, Colour.SPEAK + "Head Armor" + Colour.RESET);
        Write.Line(x + 15, 1, Colour.ITEM + g.Torso.Head.Armor.Name + Colour.RESET);
        Write.Line(x + 15, 2, Colour.SPEAK + "Body Armor" + Colour.RESET);
        Write.Line(x + 15, 3, Colour.ITEM + g.Torso.Armor.Name + Colour.RESET);
        Write.Line(x + 15, 4, Colour.SPEAK + "Leg Armor" + Colour.RESET);
        Write.Line(x + 15, 5, Colour.ITEM + g.Torso.RightLeg.Armor.Name + Colour.RESET);
        Write.Line(x + 15, 6, Colour.SPEAK + "Arm Armor" + Colour.RESET);
        Write.Line(x + 15, 7, Colour.ITEM + g.Torso.RightArm.Armor.Name + Colour.RESET);
        Write.Line(x + 15, 8, Colour.SPEAK + "Gloves" + Colour.RESET);
        Write.Line(x + 15, 9, Colour.ITEM + g.Torso.RightArm.Hand.Armor.Name + Colour.RESET);
        Write.Character(x, 11, "LOCATION", $"STATUS", "ARMOR");
        Write.Character(x, 12, "Head", g.Torso.Head.Status, g.Torso.Head.Armor.Status);
        Write.Character(x, 13, "Torso", g.Torso.Status, g.Torso.Armor.Status);
        Write.Character(x, 14, "Right Arm", g.Torso.RightArm.Status, g.Torso.RightArm.Armor.Status);
        Write.Character(x, 15, "Right Hand", g.Torso.RightArm.Hand.Status, g.Torso.RightArm.Hand.Armor.Status);
        Write.Character(x, 16, "Left Arm", g.Torso.LeftArm.Status, g.Torso.LeftArm.Armor.Status);
        Write.Character(x, 17, "Left Hand", g.Torso.LeftArm.Hand.Status, g.Torso.LeftArm.Hand.Armor.Status);
        Write.Character(x, 18, "Right Leg", g.Torso.RightLeg.Status, g.Torso.RightLeg.Armor.Status);
        Write.Character(x, 19, "Left Leg", g.Torso.LeftLeg.Status, g.Torso.LeftLeg.Armor.Status);
        Write.Line(x + 43, 0, Colour.SPEAK + "Main Hand" + Colour.RESET);
        Write.Line(x + 43, 2, Colour.SPEAK + "Off Hand" + Colour.RESET);
        Write.Line(x + 43, 1, Colour.ITEM + g.Torso.RightArm.Hand.Weapon.Name + Colour.RESET);
        Write.Line(x + 43, 3, Colour.ITEM + g.Torso.LeftArm.Hand.Weapon.Name + Colour.RESET);
        Write.Line(x + 45, 11, "Traits");
    }
}