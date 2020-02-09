using System;
using System.Collections.Generic;
using System.Text;
public class Location
{
    public static List<Location> list = new List<Location> { new Hub(), new Slaver(), new Manage(), null, null, null, null, null, null, null};

    public Location()
    {

    }

    public void Go() { Menu(); }

    public virtual void Menu() { Console.Clear(); }
}