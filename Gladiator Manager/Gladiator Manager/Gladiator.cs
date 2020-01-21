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
    protected Head head;
    protected Body torso;
    protected Arm rightArm;
    protected Arm leftArm;
    protected Leg rightLeg;
    protected Leg leftLeg;
    protected int defence;
    protected int creative;
    protected bool rightHanded;
    public Gladiator()
    {
        head = new Head();
        torso = new Body();
        rightArm = new Arm();
        leftArm = new Arm();
        rightLeg = new Leg();
        leftLeg = new Leg();
    }
    public string Name { get { return name; } set { name = value; } }
    public int Strength { get { return strength; } set { strength = value; } }
    public int Agility { get { return agility; } set { agility = value; } }
    public int Offence { get { return offence; } set { offence = value; } }
    public int Defence { get { return defence; } set { defence = value; } }
    public int Creative { get { return creative; } set { creative = value; } }
    public int Endurance { get { return endurance; } set { endurance = value; } }
    public Body Torso { get { return torso; } set { torso = value; } }
    public Head Head { get { return head; } set { head = value; } }
    public Arm RightArm { get { return rightArm; } set { rightArm = value; } }
    public Arm LeftArm { get { return leftArm; } set { leftArm = value; } }
    public Leg RightLeg { get { return rightLeg; } set { rightLeg = value; } }
    public Leg LeftLeg { get { return leftLeg; } set { leftLeg = value; } }
    public bool RightHanded { get { return rightHanded; } set { rightHanded = value; } }
}