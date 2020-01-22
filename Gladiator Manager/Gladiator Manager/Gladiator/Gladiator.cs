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

    protected Head head;
    protected Torso torso;
    protected Arm rightArm;
    protected Arm leftArm;
    protected Hand rightHand;
    protected Hand leftHand;
    protected Leg rightLeg;
    protected Leg leftLeg;

    protected bool rightHanded;

    public Gladiator()
    {
        strength = 2 + Return.RandomInt(0, 2);
        agility = 3 + Return.RandomInt(0, 4);
        offence = 3 + Return.RandomInt(0, 4);
        defence = 3 + Return.RandomInt(0, 4);
        endurance = 2 + Return.RandomInt(0, 3);
        initiative = 4 + Return.RandomInt(0, 3);
        head = new Head();
        torso = new Torso();
        rightHand = new Hand(false);
        leftHand = new Hand(false);
        rightArm = new Arm();
        leftArm = new Arm();
        rightLeg = new Leg();
        leftLeg = new Leg();   
        int choice = Return.RandomInt(0, 4);
        if (choice == 0) leftHand.Dominant = true;
        else rightHand.Dominant = true;
        rightHanded = (rightHand.Dominant) ? true : false;
    }
    public string Name { get { return name; } set { name = value; } }
    public int Strength { get { return strength; } set { strength = value; } }
    public int Initiative { get { return initiative; } set { initiative = value; } }
    public int Agility { get { return agility; } set { agility = value; } }
    public int Offence { get { return offence; } set { offence = value; } }
    public int Defence { get { return defence; } set { defence = value; } }
    public int Creative { get { return creative; } set { creative = value; } }
    public int Endurance { get { return endurance; } set { endurance = value; } }
    public Torso Torso { get { return torso; } set { torso = value; } }
    public Head Head { get { return head; } set { head = value; } }
    public Arm RightArm { get { return rightArm; } set { rightArm = value; } }
    public Arm LeftArm { get { return leftArm; } set { leftArm = value; } }
    public Hand RightHand { get { return rightHand; } set { rightHand = value; } }
    public Hand LeftHand { get { return leftHand; } set { leftHand = value; } }
    public Leg RightLeg { get { return rightLeg; } set { rightLeg = value; } }
    public Leg LeftLeg { get { return leftLeg; } set { leftLeg = value; } }
    public bool RightHanded { get { return rightHanded; } set { rightHanded = value; } }
}