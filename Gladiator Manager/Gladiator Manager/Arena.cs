﻿using System;
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
        Console.SetCursorPosition(0, 21);
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
            Write.Line(i, 10, "-");
            Write.Line(i, 20, "-");
        }
        for (int i = 0; i < 19; i++)
        {
            Write.Line(58, i, Colour.MITIGATION +"|"+Colour.RESET);
            Write.Line(59, i, Colour.MITIGATION +"|"+Colour.RESET);
        }
        Write.Line(58, 20, "+");
        Write.Line(59, 20, "+");
        Display(60, Lincoln);
    }

    private static void Display(int x, Gladiator g)
    {
        Write.Character(x, 0, g.Name, "", "");
        Write.Line(x, 2, $"Strength   {g.Strength}");   
        Write.Line(x, 3, $"Agility    {g.Agility}");   
        Write.Line(x, 4, $"Offence    {g.Offence}");   
        Write.Line(x, 5, $"Defence    {g.Defence}");
        Write.Line(x + 15, 0, Colour.SPEAK + "Head Armor" + Colour.RESET             );   
        Write.Line(x + 15, 1, Colour.ITEM + g.Torso.Head.Armor.Name + Colour.RESET    );  
        Write.Line(x + 15, 2, Colour.SPEAK + "Body Armor" + Colour.RESET             );   
        Write.Line(x + 15, 3, Colour.ITEM + g.Torso.Armor.Name + Colour.RESET      );     
        Write.Line(x + 15, 4, Colour.SPEAK + "Leg Armor" + Colour.RESET               );
        Write.Line(x + 15, 5, Colour.ITEM + g.Torso.RightLeg.Armor.Name + Colour.RESET);
        Write.Line(x + 15, 6, Colour.SPEAK + "Arm Armor" + Colour.RESET);
        Write.Line(x + 15, 7, Colour.ITEM + g.Torso.RightArm.Armor.Name + Colour.RESET);
        Write.Line(x + 15, 8, Colour.SPEAK + "Gloves" + Colour.RESET);
        Write.Line(x + 15, 9, Colour.ITEM + g.Torso.RightArm.Hand.Armor.Name + Colour.RESET);
        Write.Character(x, 11, "LOCATION", $"STATUS", "ARMOR");
        Write.Character(x, 12, "Head",          g.Torso.Head.Status,            g.Torso.Head.Armor.Status);
        Write.Character(x, 13, "Torso",         g.Torso.Status,                 g.Torso.Armor.Status);
        Write.Character(x, 14, "Right Arm",     g.Torso.RightArm.Status,        g.Torso.RightArm.Armor.Status);
        Write.Character(x, 15, "Right Hand",    g.Torso.RightArm.Hand.Status,   g.Torso.RightArm.Hand.Armor.Status);
        Write.Character(x, 16, "Left Arm",      g.Torso.LeftArm.Status,         g.Torso.LeftArm.Armor.Status);
        Write.Character(x, 17, "Left Hand",     g.Torso.LeftArm.Hand.Status,    g.Torso.LeftArm.Hand.Armor.Status);
        Write.Character(x, 18, "Right Leg",     g.Torso.RightLeg.Status,        g.Torso.RightLeg.Armor.Status);
        Write.Character(x, 19, "Left Leg",      g.Torso.LeftLeg.Status,         g.Torso.LeftLeg.Armor.Status);
        Write.Line(x + 43, 0, Colour.SPEAK + "Main Hand" + Colour.RESET);  
        Write.Line(x + 43, 2, Colour.SPEAK + "Off Hand" + Colour.RESET);
        Write.Line(x + 43, 1, Colour.ITEM + g.Torso.RightArm.Hand.Weapon + Colour.RESET);
        Write.Line(x + 43, 3, Colour.ITEM + g.Torso.LeftArm.Hand.Weapon + Colour.RESET);
        Write.Line(x + 45, 11, "Traits");
    }
}