using System;
using System.Collections.Generic;
using System.Text;

public class Owner
{    
    public static Owner p = Gladiator_Manager.Program.p;
    protected string name;
    protected int prestige;
    protected int gold;
    protected int actions;
    protected int win;
    protected int loss;
    List<Gladiator> roster = new List<Gladiator> { } ;
    public Owner()
    {
        prestige = 100;
        gold = 1000;
        actions = 3;
        win = 0;
        loss = 0;        
    }
    public string Name { get { return name; } set { name = value; } }
    public int Prestige { get { return prestige; } set { prestige = value; } }
    public int Gold { get { return gold; } set { gold = value; } }
    public int Action { get { return actions; } set { actions = value; } }
    public int Win { get { return win; } set { win = value; } }
    public int Loss { get { return loss; } set { loss = value; } }
    public List<Gladiator> Roster { get { return roster; } set { roster = value; } }
}