using System;

namespace Gladiator_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Colour.SetupConsole();
            Location.list[0].Go();    
        }       
    }
}
