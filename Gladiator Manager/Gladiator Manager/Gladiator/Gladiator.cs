using System;
using System.Collections.Generic;
using System.Text;

public class Gladiator
{
    protected string name;
    protected int strength;
    protected int agility;
    protected int offence;
    protected int endurance;
    protected int defence;
    protected int initiative;
    protected int creative;  
    protected Torso torso;
    protected bool rightHanded;

    public Gladiator()
    {
        strength = 2 + Return.RandomInt(0, 2);
        agility = 3 + Return.RandomInt(0, 4);
        offence = 3 + Return.RandomInt(0, 4);
        defence = 3 + Return.RandomInt(0, 4);
        endurance = 2 + Return.RandomInt(0, 3);
        initiative = 4 + Return.RandomInt(0, 3);
        torso = new Torso();
        rightHanded = true;
    }
    public string Name { get { return name; } set { name = value; } }
    public int Strength { get { return strength; } set { strength = value; } }
    public int Initiative { get { return initiative; } set { initiative = value; } }
    public int Agility { get { return agility; } set { agility = value; } }
    public int Offence { get { return offence; } set { offence = value; } }
    public int Defence { get { return defence; } set { defence = value; } }
    public int Creative { get { return creative; } set { creative = value; } }
    public int Endurance { get { return endurance; } set { endurance = value; } }
    public bool RightHanded { get { return rightHanded; } set { rightHanded = value; } }
    public Torso Torso { get { return torso; } set { torso = value; } }
    public bool DeathCheck()
    {
        return (Torso.Destroyed|| Torso.Head.Destroyed);
    }
}