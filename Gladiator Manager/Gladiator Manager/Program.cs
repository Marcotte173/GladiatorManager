using System;

namespace Gladiator_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Colour.SetupConsole();
            Write.Line(Colour.RESET);
            Location.list[0].Go();    
        }       
    }
}
