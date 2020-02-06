using System;
using System.Collections.Generic;
using System.Text;

public enum Trait {MissingArm,MissingLeg,OneEye,Blind,MissingHand,Unflappable,FastLearner,SlowLearner,BladeMaster,ShieldExpert,HeightenedSenses,UnarmedMaster,Afraid,DeathResistant}; 
public class Gladiator
{
    protected string name;
    protected int strength;
    protected int offence;
    protected int endurance;
    protected int maxEndurance;
    protected int defence;
    protected int creative;  
    protected Torso torso;
    protected bool rightHanded;
    protected int win;
    protected int price;
    protected Owner owner;
    protected List<Trait> traits = new List<Trait> { };
    public static List<string> list = new List<string> { };

    public Gladiator(int x)
    {
        int t = Return.RandomInt(5, 14);
        if (t > 4 && t < 14)
        {
            traits.Add((Trait)t);
        }
        strength = x + Return.RandomInt(0, 1 + x);
        offence = x + Return.RandomInt(0, 1 + x);
        defence = x + Return.RandomInt(0, 1 + x);
        endurance = maxEndurance = x + Return.RandomInt(0, 2 + x);
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
    public int MaxEndurance { get { return maxEndurance; } set { maxEndurance = value; } }
    public bool RightHanded { get { return rightHanded; } set { rightHanded = value; } }
    public Owner Owner { get { return owner; } set { owner = value; } }
    public Torso Torso { get { return torso; } set { torso = value; } }
    public List<Trait> Traits { get { return traits; } set { traits = value; } }
    public string Trait1 
    { 
        get 
        {
            if (traits[0] == Trait.Afraid) return "Afraid";
            else if (traits[0] == Trait.DeathResistant) return "Death Resistant";
            else if (traits[0] == Trait.UnarmedMaster) return "Unarmed Master";
            else if (traits[0] == Trait.HeightenedSenses) return "Heightened Senses";
            else if (traits[0] == Trait.ShieldExpert) return "Shield Expert";
            else if (traits[0] == Trait.BladeMaster) return "Blade Master";
            else if (traits[0] == Trait.SlowLearner) return "Slow Learner";
            else if (traits[0] == Trait.FastLearner) return "Fast Learner";
            else return "Unflappable";
        } 
    }

    internal int Fatigue { get { return  2 + torso.Head.Armor.Fatigue + torso.Armor.Fatigue + torso.RightArm.Armor.Fatigue + torso.RightArm.Hand.Armor.Fatigue + torso.LeftArm.Armor.Fatigue + torso.LeftArm.Hand.Armor.Fatigue + torso.RightLeg.Armor.Fatigue + torso.LeftLeg.Armor.Fatigue; } }

    public string Trait2
    {
        get
        {
            if (traits[0] == Trait.Afraid) return "Afraid";
            else if (traits[0] == Trait.DeathResistant) return "Death Resistant";
            else if (traits[0] == Trait.UnarmedMaster) return "Unarmed Master";
            else if (traits[0] == Trait.HeightenedSenses) return "Heightened Senses";
            else if (traits[0] == Trait.ShieldExpert) return "Shield Expert";
            else if (traits[0] == Trait.BladeMaster) return "Blade Master";
            else if (traits[0] == Trait.SlowLearner) return "Slow Learner";
            else if (traits[0] == Trait.FastLearner) return "Fast Learner";
            else return "Unflappable";
        }
    }
    public string Trait3
    {
        get
        {
            if (traits[0] == Trait.Afraid) return "Afraid";
            else if (traits[0] == Trait.DeathResistant) return "Death Resistant";
            else if (traits[0] == Trait.UnarmedMaster) return "Unarmed Master";
            else if (traits[0] == Trait.HeightenedSenses) return "Heightened Senses";
            else if (traits[0] == Trait.ShieldExpert) return "Shield Expert";
            else if (traits[0] == Trait.BladeMaster) return "Blade Master";
            else if (traits[0] == Trait.SlowLearner) return "Slow Learner";
            else if (traits[0] == Trait.FastLearner) return "Fast Learner";
            else return "Unflappable";
        }
    }
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