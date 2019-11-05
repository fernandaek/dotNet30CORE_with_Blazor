using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1.Classes.Chapter_12_Inheritance
{
    public class Liquid : Matter
    {
        public Liquid(string name, double mass) : base(name, mass)
        {
        }
        public override States State => GetState(GetType().Name);

        public override string GetCompression() => $"{Name} ({State}): Does not compress easily.";
        public override string GetShape() => $"{Name} ({State}): Assumes the shape of the part of the container which it occupies.";
        public override string ParticleMovement() => $"{Name} ({State}): Particles can move/slide past one another.";
    }
}
