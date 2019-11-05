using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1.Classes.Chapter_11_Interfaces
{
    public class Gas : IMatter
    {
        public string Name { get; }

        public double Mass { get; }

        public States State => States.Liquid;

        public Gas(string name, double mass)
        {
            Name = name;
            Mass = mass;
        }

        public string GetCompression()
        {
            return $"{Name} ({State}): Is compressible.";
        }

        public string GetShape()
        {
            return $"{Name} ({State}): assumes the shape and volume of its container.";
        }

        public string ParticleMovement()
        {
            return $"{Name} ({State}): particles can move past one another.";
        }
    }
}
