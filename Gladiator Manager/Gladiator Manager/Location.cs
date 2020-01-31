using System;
using System.Collections.Generic;
using System.Text;
public class Location
{
    public static  List<Location> list = new List<Location> { new Arena() };

    public Location()
    {

    }

    public void Go() { Menu(); }

    public virtual void Menu() { }
}