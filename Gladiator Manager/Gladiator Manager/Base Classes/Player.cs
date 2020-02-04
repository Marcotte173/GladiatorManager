using System;
using System.Collections.Generic;
using System.Text;

public class Player
{    
    public static Player p = Gladiator_Manager.Program.p;
    string name;
    int prestige;
    int gold;
    int actions;
    int win;
    int loss;
    Gladiator[] roster = new Gladiator[5] ;
    public Player()
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
    public Gladiator[] Roster { get { return roster; } set { roster = value; } }
}