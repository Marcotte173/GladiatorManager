using System;
using System.Collections.Generic;
using System.Text;

public class Arena:Location
{
    internal static Gladiator Marcotte = new Gladiator();
    internal static Gladiator Lincoln = new Gladiator();
    public Arena()
    :base()
    {
        Marcotte.Name = "Marcotte";
        Lincoln.Name = "Lincoln";
    }
    public override void Menu()
    {
        Display(0, Marcotte);
        Display(65, Lincoln);
        Console.ReadLine();
        Fight();
    }

    private void Fight()
    {
        Console.Clear();
        Console.SetCursorPosition(0, 20);
        Marcotte.Attack(Lincoln);
        Lincoln.Attack(Marcotte);
        Display(0, Marcotte);
        Display(65, Lincoln);
        if (Marcotte.DeathCheck()) EndFight(Lincoln, Marcotte);
        else if (Lincoln.DeathCheck()) EndFight(Marcotte, Lincoln);
        Console.ReadKey(true);
        Fight();
    }
    private static void EndFight(Gladiator a, Gladiator b)
    {
        Console.SetCursorPosition(0, 26);
        Console.WriteLine(Colour.NAME + $"{b.Name} " + Colour.RESET + "has been killed by " + Colour.NAME + a.Name + "!");
        Console.ReadKey(true);
        Environment.Exit(0);
    }

    private static void Display(int x, Gladiator g)
    {
        Write.Character(x, 0, g.Name, "", "","");
        Write.Character(x, 2, "Strength", $"{g.Strength}", "","");
        Write.Character(x, 3, "Agility", $"{g.Agility}", "","");
        Write.Character(x, 4, "Offence", $"{g.Offence}", "","");
        Write.Character(x, 5, "Defence", $"{g.Defence}", "","");
        Write.Character(x, 8, "LOCATION", $"STATUS", "ARMOR","STATUS");
        Write.Character(x, 9, "Head",           g.Torso.Head.Status,            g.Torso.Head.Armor.Name,            g.Torso.Head.Armor.Status);
        Write.Character(x, 10, "Torso",         g.Torso.Status,                 g.Torso.Armor.Name,                 g.Torso.Armor.Status);
        Write.Character(x, 11, "Right Arm",     g.Torso.RightArm.Status,        g.Torso.RightArm.Armor.Name,        g.Torso.RightArm.Armor.Status);
        Write.Character(x, 12, "Right Hand",    g.Torso.RightArm.Hand.Status,   g.Torso.RightArm.Hand.Armor.Name,   g.Torso.RightArm.Hand.Armor.Status);
        Write.Character(x, 13, "Left Arm",      g.Torso.LeftArm.Status,         g.Torso.LeftArm.Armor.Name,         g.Torso.LeftArm.Armor.Status);
        Write.Character(x, 14, "Left Hand",     g.Torso.LeftArm.Hand.Status,    g.Torso.LeftArm.Hand.Armor.Name,    g.Torso.LeftArm.Hand.Armor.Status);
        Write.Character(x, 15, "Right Leg",     g.Torso.RightLeg.Status,        g.Torso.RightLeg.Armor.Name,        g.Torso.RightLeg.Armor.Status);
        Write.Character(x, 16, "Left Leg",      g.Torso.LeftLeg.Status,         g.Torso.LeftLeg.Armor.Name,         g.Torso.LeftLeg.Armor.Status);
    }
}