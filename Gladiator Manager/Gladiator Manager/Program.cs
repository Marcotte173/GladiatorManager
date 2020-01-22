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
            Console.ReadLine();
            Start();
        }        

        private static void Display(int x, Gladiator g)
        {
            Write.Character(x, 1, g.Name,"");
            Write.Character(x, 2, "Strength", $"{g.Strength}");
            Write.Character(x, 3, "Agility", $"{g.Agility}");
            Write.Character(x, 4, "Offence", $"{g.Offence}");
            Write.Character(x, 5, "Defence", $"{g.Defence}");
            Write.Character(x, 7, "Head", $"{g.Head.Status}");
            Write.Character(x, 8, "Torso", $"{g.Torso.Status}");
            Write.Character(x, 9, "Right Arm", $"{g.RightArm.Status}");
            Write.Character(x, 10, "Right Hand", $"{g.RightHand.Status}");
            Write.Character(x, 11, "Left Arm", $"{g.LeftArm.Status}");
            Write.Character(x, 12, "Left Hand", $"{g.LeftHand.Status}");
            Write.Character(x, 13, "Right Leg", $"{g.RightLeg.Status}");
            Write.Character(x, 14, "Left Leg", $"{g.LeftLeg.Status}");
        }
    }
}
