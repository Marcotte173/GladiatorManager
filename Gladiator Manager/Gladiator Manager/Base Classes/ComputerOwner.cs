using System;
using System.Collections.Generic;
using System.Text;

public class ComputerOwner:Owner
{
    public static List<ComputerOwner> list = new List<ComputerOwner> { };
    public ComputerOwner(int gladiators, int level, int goldBoost, int prestigeBoost)
    : base()
    {
        prestige = 100 + prestigeBoost;
        gold = 1000 + goldBoost;
        win = 0;
        loss = 0;
        name = Gladiator.list[Return.RandomInt(0, list.Count)];
    }
}