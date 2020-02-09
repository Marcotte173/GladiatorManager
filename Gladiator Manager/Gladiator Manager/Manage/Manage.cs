using System;
using System.Collections.Generic;
using System.Text;

public class Manage:Location
{
    public Manage()
    : base()
    {

    }
    public override void Menu()
    {
        Console.Clear();
        Write.Line("You are at your compound, surveying your team.");
        Write.Line("From here you can manage your gladiators. \nTraining, Healing, you can even try to help them gain a competitive edge");
        Return.Roster(Owner.p);
        Console.ReadKey(true);
        Write.Line(0, 18, "[1] " + Colour.GOLD + "Hire Gladiators\n" + Colour.RESET);
        Write.Line("[2] " + Colour.ENERGY + "Manage Gladiators" + Colour.RESET);
        Write.Line("[3] " + Colour.ITEM + "Purchase Equipment" + Colour.RESET);
    }
}