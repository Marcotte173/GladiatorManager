using System;
using System.Collections.Generic;
using System.Text;

public class Gladiator
{
    protected string name;
    protected int strength;
    protected int offence;
    protected int endurance;
    protected int defence;
    protected int creative;  
    protected Torso torso;
    protected bool rightHanded;
    protected int win;
    protected int price;
    protected Owner owner;
    public static List<string> list = new List<string> { };

    public Gladiator(int x)
    {
        strength = x + Return.RandomInt(0, 1 + x);
        offence = x + Return.RandomInt(0, 1 + x);
        defence = x + Return.RandomInt(0, 1 + x);
        endurance = x + Return.RandomInt(0, 2 + x);
        torso = new Torso();
        rightHanded = true;
        price = (strength + offence + defence + endurance) / 4 * 350 + Return.RandomInt(-125, 126);
        name = list[Return.RandomInt(0, list.Count)];
    }
    public string Name { get { return name; } set { name = value; } }
    public int Strength { get { return strength; } set { strength = value; } }
    public int Offence { get { return offence; } set { offence = value; } }
    public int Defence { get { return defence; } set { defence = value; } }
    public int Win { get { return win; } set { win = value; } }
    public int Creative { get { return creative; } set { creative = value; } }
    public int Endurance { get { return endurance; } set { endurance = value; } }
    public bool RightHanded { get { return rightHanded; } set { rightHanded = value; } }
    public Owner Owner { get { return owner; } set { owner = value; } }
    public Torso Torso { get { return torso; } set { torso = value; } }
    public int Price 
    { 
        get 
        {
            return
            price;
        } 
    }
    public bool DeathCheck()
    {
        return (Torso.Disabled|| Torso.Head.Disabled);
    }
    
    internal static void Create(int x)
    {
        Slaver.list.Add(new Gladiator(x));
    }
}