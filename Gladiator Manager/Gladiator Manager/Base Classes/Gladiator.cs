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
    protected int initiative;
    protected int creative;  
    protected Torso torso;
    protected bool rightHanded;
    protected int win;
    protected int price;
    public static List<string> list = new List<string> { };

    public Gladiator(int x)
    {
        strength = x + Return.RandomInt(0, 1 + x);
        offence = x + Return.RandomInt(0, 1 + x);
        defence = x + Return.RandomInt(0, 1 + x);
        endurance = x + Return.RandomInt(0, 2 + x);
        initiative = x + Return.RandomInt(0, 2 + x);
        torso = new Torso();
        rightHanded = true;
        price = (strength + offence + defence + endurance + initiative) / 5 * 375 + Return.RandomInt(-250, 251);
        name = list[Return.RandomInt(0, list.Count)];
    }
    public string Name { get { return name; } set { name = value; } }
    public int Strength { get { return strength; } set { strength = value; } }
    public int Initiative { get { return initiative; } set { initiative = value; } }
    public int Offence { get { return offence; } set { offence = value; } }
    public int Defence { get { return defence; } set { defence = value; } }
    public int Win { get { return win; } set { win = value; } }
    public int Creative { get { return creative; } set { creative = value; } }
    public int Endurance { get { return endurance; } set { endurance = value; } }
    public bool RightHanded { get { return rightHanded; } set { rightHanded = value; } }
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
        return (Torso.Destroyed|| Torso.Head.Destroyed);
    }
    public void Attack(Gladiator p)
    {
        if (torso.LeftArm.Hand.Destroyed == false && Torso.RightArm.Hand.Destroyed == false)
        {
            if (RightHanded) WeaponCheck(Torso.RightArm.Hand, p);
            else WeaponCheck(Torso.LeftArm.Hand, p);
        }
        else if (Torso.LeftArm.Hand.Destroyed && Torso.RightArm.Hand.Destroyed == false) WeaponCheck(Torso.RightArm.Hand, p);
        else if (Torso.LeftArm.Hand.Destroyed == false && Torso.RightArm.Hand.Destroyed) WeaponCheck(Torso.LeftArm.Hand, p);
        else if (Torso.LeftArm.Hand.Destroyed && Torso.RightArm.Hand.Destroyed) Console.WriteLine(Name + " cannot attack without arms. He waits for death");
    }
    private void WeaponCheck(Hand hand, Gladiator p)
    {
        if (hand.Weapon.Level != 0) hand.Weapon.Attack(this,p);
        else hand.Attack(this,p);
    }
    internal Body Target(Gladiator g, int y)
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
    internal static void Create(int x)
    {
        Slaver.list.Add(new Gladiator(x));
    }
}