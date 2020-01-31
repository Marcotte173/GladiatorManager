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
        UI();
        Console.ReadLine();
        Fight();
    }

    private void Fight()
    {
        Console.Clear();
        Console.SetCursorPosition(0, 20);
        Marcotte.Attack(Lincoln);
        Lincoln.Attack(Marcotte);
        UI();
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

    private static void UI()
    {
        Display(0, Marcotte);
        for (int i = 0; i < 120; i++)
        {
            Write.Line(i, 7, "-");
            Write.Line(i, 17, "-");
        }
        for (int i = 0; i < 17; i++)
        {
            Write.Line(58, i, Colour.MITIGATION +"|"+Colour.RESET);
            Write.Line(59, i, Colour.MITIGATION +"|"+Colour.RESET);
        }
        Write.Line(58, 17, "+");
        Write.Line(59, 17, "+");
        Display(60, Lincoln);
    }

    private static void Display(int x, Gladiator g)
    {
        Write.Character(x, 0, g.Name, "", "");
        Write.Character(x, 2, $"Strength   {g.Strength}", Colour.SPEAK + "Head Armor" + Colour.RESET, Colour.SPEAK + "Arm Armor" + Colour.RESET, Colour.SPEAK + "Leg Armor" + Colour.RESET);
        Write.Character(x, 3, $"Agility    {g.Agility}", Colour.ITEM + g.Torso.Head.Armor.Name + Colour.RESET,            "","");
        Write.Character(x, 4, $"Offence    {g.Offence}", Colour.SPEAK + "Body Armor" + Colour.RESET, Colour.SPEAK + "Gloves" + Colour.RESET, "");
        Write.Character(x, 5, $"Defence    {g.Defence}", Colour.ITEM + g.Torso.Armor.Name + Colour.RESET,            "","");
        Write.Character(x, 8, "LOCATION", $"STATUS", "ARMOR");
        Write.Character(x, 9, "Head",           g.Torso.Head.Status,            g.Torso.Head.Armor.Status);
        Write.Character(x, 10, "Torso",         g.Torso.Status,                 g.Torso.Armor.Status);
        Write.Character(x, 11, "Right Arm",     g.Torso.RightArm.Status,        g.Torso.RightArm.Armor.Status);
        Write.Character(x, 12, "Right Hand",    g.Torso.RightArm.Hand.Status,   g.Torso.RightArm.Hand.Armor.Status);
        Write.Character(x, 13, "Left Arm",      g.Torso.LeftArm.Status,         g.Torso.LeftArm.Armor.Status);
        Write.Character(x, 14, "Left Hand",     g.Torso.LeftArm.Hand.Status,    g.Torso.LeftArm.Hand.Armor.Status);
        Write.Character(x, 15, "Right Leg",     g.Torso.RightLeg.Status,        g.Torso.RightLeg.Armor.Status);
        Write.Character(x, 16, "Left Leg",      g.Torso.LeftLeg.Status,         g.Torso.LeftLeg.Armor.Status);
        Write.Line(x + 38, 8, Colour.SPEAK + "Main Hand" + Colour.RESET);
        Write.Line(x + 50, 8, Colour.SPEAK + "Off Hand" + Colour.RESET);
        Write.Line(x + 38, 9, Colour.ITEM + g.Torso.RightArm.Hand.Weapon + Colour.RESET);
        Write.Line(x + 50, 9, Colour.ITEM + g.Torso.LeftArm.Hand.Weapon + Colour.RESET);
        Write.Line(x + 45, 12, "Traits");
    }
}