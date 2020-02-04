using System;
using System.Collections.Generic;
using System.Text;

public class Hub:Location
{
    static Player p = Player.p;
    static int day = 1;
    static bool audience;
    public Hub()
    : base()
    {

    }
    public override void Menu()
    {
        Console.Clear();
        Write.Line(60, 28, Colour.TIME + $"It is Day { day}" + Colour.RESET);
        Write.Line(0, 0, $"You have " + Colour.GOLD + $"{p.Gold}" + Colour.RESET + " Gold");
        Write.Line(45, 0, $"You have " + Colour.XP + $"{p.Prestige}" + Colour.RESET + " Prestige");
        Write.Line(90, 0, $"You have " + Colour.ENERGY + $"{p.Action}" + Colour.RESET + " remaining actions");
        Roster();
        while (day < 21)
        {
            
            Write.Line(0, 18, "[1] " + Colour.GOLD + "Hire Gladiators\n" + Colour.RESET);
            Write.Line("[2] " + Colour.ENERGY + "Manage Gladiators" + Colour.RESET);
            Write.Line("[3] " + Colour.ITEM + "Purchase Equipment" + Colour.RESET);
            Write.Line("[4] " + Colour.ENERGY + "Jobs" + Colour.RESET);
            Write.Line("[5] " + Colour.ENERGY + "Shady Jobs" + Colour.RESET);
            Write.Line("[6] " + Colour.DEFENCE + "Graveyard" + Colour.RESET);
            if (day == 10) Write.Line("[7] " + Colour.XP + "Petition the senate" + Colour.RESET);
            else Write.Line("[X] " + Colour.MITIGATION + "The senate will not hear you" + Colour.RESET);
            if (audience) Write.Line("[8] Audience with the emperor");
            else Write.Line("[X] " + Colour.MITIGATION + "The emperor has no interest in you" + Colour.RESET);
            if (day % 2 == 0) Write.Line("[9] " + Colour.DAMAGE + "Fight" + Colour.RESET);
            else Write.Line("[X] " + Colour.MITIGATION + "There are no fights today" + Colour.RESET);
            Write.Line("[0] " + Colour.TIME + "Next day" + Colour.RESET);
            Write.Line("[?] Help");


            string choice = Return.Option();
            if (choice == "1") Location.list[1].Go();
            else if (choice == "9") Location.list[2].Go();
            else if (choice == "0")
            {
                day++;
                p.Action = 3;
                if (day % 3 == 0) Slaver.NewStock();
            };
            Menu();
        }        
    }

    private void Roster()
    {
        int x = 5;
        for (int i = 0; i < 5; i++)
        {            
            if (p.Roster[i] != null)
            {
                Write.Line(x, 8,  Colour.NAME +p.Roster[i].Name+ Colour.RESET);
                Write.Line(x, 10, $"Wins      {p.Roster[i].Win}");
                Write.Line(x, 11, $"Strength  {p.Roster[i].Strength}");
                Write.Line(x, 12, $"Offence   {p.Roster[i].Offence}");
                Write.Line(x, 13, $"Defence   {p.Roster[i].Defence}");
                x += 25;
            }
        }
        


    }
}