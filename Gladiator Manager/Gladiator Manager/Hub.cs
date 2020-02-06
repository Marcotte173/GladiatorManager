using System;
using System.Collections.Generic;
using System.Text;

public class Hub:Location
{
    static Owner p = Owner.p;
    static List<ComputerOwner> ownerList = ComputerOwner.list;
    static int day = 1;
    static List<List<Gladiator>> matches = new List<List<Gladiator>> 
    { 
        new List<Gladiator>{p.Roster[0],ownerList[1].Roster[0]},
        new List<Gladiator>{ownerList[2].Roster[0],ownerList[3].Roster[0]},
        new List<Gladiator>{ownerList[4].Roster[0],ownerList[5].Roster[0]},
        new List<Gladiator>{ownerList[6].Roster[0],ownerList[7].Roster[0]},
        new List<Gladiator>{ownerList[8].Roster[0],ownerList[9].Roster[0]}
    };
    static List<int> matchNumbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
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
        while (day < 11)
        {            
            Write.Line(0, 18, "[1] " + Colour.GOLD + "Hire Gladiators\n" + Colour.RESET);
            Write.Line("[2] " + Colour.ENERGY + "Manage Gladiators" + Colour.RESET);
            Write.Line("[3] " + Colour.ITEM + "Purchase Equipment" + Colour.RESET);
            Write.Line("[4] " + Colour.ENERGY + "Jobs" + Colour.RESET);
            Write.Line("[5] " + Colour.ENERGY + "Shady Jobs" + Colour.RESET);
            Write.Line("[6] " + Colour.DEFENCE + "Graveyard" + Colour.RESET);
            Write.Line("[7] " + Colour.BURNING + "View your competition" + Colour.RESET);
            if (audience) Write.Line("[8] " + Colour.XP + "Audience with the emperor" + Colour.RESET);
            else Write.Line("[X] " + Colour.MITIGATION + "The emperor has no interest in you" + Colour.RESET);
            if (matches.Count <1) Write.Line("[9] " + Colour.DAMAGE + "Fight" + Colour.RESET);
            else Write.Line("[X] " + Colour.MITIGATION + "There are no fights today" + Colour.RESET);
            Write.Line("[0] " + Colour.TIME + "Next day" + Colour.RESET);
            Write.Line("[?] Help");
            string choice = Return.Option();
            if (choice == "1") Location.list[1].Go();
            else if (choice == "9" && day % 2 == 0)
            {
                foreach(List<Gladiator> match in matches)
                {
                    Arena.Match(match[0], match[1]);
                }
                matches.Clear();
            }
            else if (choice == "0")
            {
                day++;
                matches.Add(new List<Gladiator> { p.Roster[0], ownerList[day].Roster[0] });

                p.Action = 3;
                if (day % 3 == 0) Slaver.NewStock();
                Recap.Go();
            };
            Menu();
        }        
    }

    private void Roster()
    {
        int x = 5;
        for (int i = 0; i < p.Roster.Count; i++)
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