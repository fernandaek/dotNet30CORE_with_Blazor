using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1.Classes.Chapter_12_Inheritance
{
    public class Gas : Matter
    {
        public Gas(string name, double mass) : base(name, mass)
        {
        }
        public override States State => GetState(GetType().Name);

        public override string GetCompression() => $"{Name} ({State}): is compressible.";
        public override string GetShape() => $"{Name} ({State}): assumes the shape and volume of its container.";
        public override string ParticleMovement() => $"{Name} ({State}): particles can move past one another.";
    }
}
