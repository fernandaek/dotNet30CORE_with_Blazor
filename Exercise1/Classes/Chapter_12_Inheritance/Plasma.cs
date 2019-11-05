using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1.Classes.Chapter_12_Inheritance
{
    public class Plasma : Matter
    {
        public Plasma(string name, double mass) : base(name, mass)
        {
        }
        public override States State => GetState(GetType().Name);

        public override string GetCompression() => $"{Name} ({State}): Is compressible.";
        public override string GetShape() => $"{Name} ({State}): Does not have a shape or volume.";
        public override string ParticleMovement() => $"{Name} ({State}): Particles are spread out and move randomly; contains some free ions and electrons, which gives plasma its ability to conduct electricity..";
    }
}
