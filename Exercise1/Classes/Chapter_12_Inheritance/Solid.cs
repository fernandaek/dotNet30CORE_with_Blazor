using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1.Classes.Chapter_12_Inheritance
{
    public class Solid : Matter
    {
        public Solid(string name, double mass) : base(name, mass)
        {
        }
        public override States State => GetState(GetType().Name);

        public override string GetCompression() => $"{Name} ({State}): not easily compressible";
        public override string GetShape() => $"{Name} ({State}): retains a fixed volume and shape.";
        public override string ParticleMovement() => $"{Name} ({State}): rigid - particles cannot move/slide past one another.";
        public override sealed string GetData() => $"{Name} {Mass} This is a solid";
    }
}
