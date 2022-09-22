using System;
namespace AbstractExample.Models
{
    public class Horse : Animal
    {
        public Horse(string name) { Name = name; }

        public Horse() { }
        public override void MakeNoise() { Console.WriteLine("NEIGH"); }
        public override void Sleep() { Console.WriteLine("Sleeping horse noises"); }
    }
}