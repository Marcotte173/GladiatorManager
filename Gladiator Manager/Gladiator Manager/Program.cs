using System;

namespace Gladiator_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Gladiator g = new Gladiator();
            g.Name = "Marcotte";
            Console.WriteLine($"{g.Name} \nHead - {g.Head.HP} hp\nBody - {g.Torso.HP} hp");
            Console.ReadLine();
        }
    }
}
