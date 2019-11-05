using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1.Classes.Chapter_11_Interfaces
{
    public class Plasma : IMatter
    {
        public string Name { get; }

        public double Mass { get; }

        public States State => States.Liquid;

        public Plasma(string name, double mass)
        {
            Name = name;
            Mass = mass;
        }

        public string GetCompression()
        {
            return $"{Name} ({State}): Compressible.";
        }

        public string GetShape()
        {
            return $"{Name} ({State}): Does not have a shape or volume.";
        }

        public string ParticleMovement()
        {
            return $"{Name} ({State}): Particles are spread out and move randomly; Contain some free ions and electrons, which gives plasma its ability to conduct electricity.";
        }
    }
}
