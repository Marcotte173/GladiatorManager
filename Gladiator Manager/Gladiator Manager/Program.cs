using System;

namespace Gladiator_Manager
{
    class Program
    {
        internal static Gladiator Marcotte = new Gladiator();
        internal static Gladiator Lincoln= new Gladiator();

        static void Main(string[] args)
        {
            Colour.SetupConsole();
            Marcotte.Name = Colour.NAME + "Marcotte" + Colour.RESET;
            Lincoln.Name = Colour.NAME + "Lincoln" + Colour.RESET;
            Display(0, Marcotte);
            Display(50, Lincoln);
            Console.ReadLine();
            Start();            
        }

        private static void Start()
        {
            Console.Clear();         
            Combat.Calculate(Marcotte, Lincoln);
            Display(0, Marcotte);
            Display(50, Lincoln);
            if (Marcotte.DeathCheck()) EndFight(Lincoln, Marcotte);
            else if (Lincoln.DeathCheck()) EndFight(Marcotte, Lincoln);
            Console.ReadKey(true);
            Start();
        }

        private static void EndFight(Gladiator a, Gladiator b)
        {
            Console.SetCursorPosition(0, 26);
            Console.WriteLine(Colour.NAME + $"{b.Name} " + Colour.RESET + "has been killed by " + Colour.NAME + a.Name + "!");
            Console.ReadKey(true);
            Environment.Exit(0);
        }

        private static void Display(int x, Gladiator g)
        {
            Write.Character(x, 1, g.Name,"");
            Write.Character(x, 2, "Strength", $"{g.Strength}");
            Write.Character(x, 3, "Agility", $"{g.Agility}");
            Write.Character(x, 4, "Offence", $"{g.Offence}");
            Write.Character(x, 5, "Defence", $"{g.Defence}");
            Write.Character(x, 7, "Head", $"{g.Torso.Head.Status}");
            Write.Character(x, 8, "Torso", $"{g.Torso.Status}");
            Write.Character(x, 9, "Right Arm", $"{g.Torso.RightArm.Status}");
            Write.Character(x, 10, "Right Hand", $"{g.Torso.RightArm.Hand.Status}");
            Write.Character(x, 11, "Left Arm", $"{g.Torso.LeftArm.Status}");
            Write.Character(x, 12, "Left Hand", $"{g.Torso.LeftArm.Hand.Status}");
            Write.Character(x, 13, "Right Leg", $"{g.Torso.RightLeg.Status}");
            Write.Character(x, 14, "Left Leg", $"{g.Torso.LeftLeg.Status}");
        }
    }
}
