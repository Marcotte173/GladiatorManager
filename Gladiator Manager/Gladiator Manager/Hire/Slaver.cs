using System;
using System.Collections.Generic;
using System.Text;

public class Slaver : Location
{
    new List<Gladiator> list = new List<Gladiator> { };
    public Slaver()
    : base()
    {
         
    }

    public override void Menu()
    {
        base.Menu();
        Console.WriteLine("You walk into the slaver's compound");
        Console.WriteLine("Rizzo walks up to you");
        Write.Line("'Greeting my friend! You're here for new gladiators, yes? Come take a look!'");
        Write.KeyPress();
        Display();
    }

    private void Display()
    {
        for (int i = 0; i < list.Count; i++)
        {
            Write.Line(0, i, list[i].Name, list[i].Strength.ToString(), list[i].Offence.ToString(), list[i].Defence.ToString(), list[i].Endurance.ToString(), list[i].Price.ToString());
        }
        Write.KeyPress();
    }
}