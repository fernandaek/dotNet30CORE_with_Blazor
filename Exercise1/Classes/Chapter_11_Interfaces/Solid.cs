using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1.Classes.Chapter_11_Interfaces
{
    public class Solid : IMatter
    {
        public string Name { get; }

        public double Mass { get; }

        public States State => States.Liquid;

        public Solid(string name, double mass)
        {
            Name = name;
            Mass = mass;
        }

        public string GetCompression()
        {
            return $"{Name} ({State}): Not easily compressible.";
        }

        public string GetShape()
        {
            return $"{Name} ({State}): Retains a fixed volume and shape.";
        }

        public string ParticleMovement()
        {
            return $"{Name} ({State}): Rigid -particles cannot move/slide past one another.";
        }
    }
}
