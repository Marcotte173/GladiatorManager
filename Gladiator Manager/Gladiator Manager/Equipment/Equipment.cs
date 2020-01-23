using System;
using System.Collections.Generic;
using System.Text;

public class Equipment
{
    protected string name;
    protected int tier;
    protected int level;
    
    public Equipment(int level, int tier)
    {
        this.level = level;
        this.tier = tier;
    }
    
    public string Name { get { return name; } set { name = value; } }
    public int Level { get { return level; } set { level = value; } }
    public int Tier { get { return tier; } set { tier = value; } }
    
}