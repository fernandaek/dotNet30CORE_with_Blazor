using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1.Classes.Chapter_12_Inheritance
{
    public abstract class Matter
    {
        public string Name { get; }
        public double Mass { get; }
        public abstract States State { get; }

        protected Matter(string name, double mass)
        {
            Name = name;
            Mass = mass;
        }

        protected States GetState(string name)
        {
            return (States)Enum.Parse(typeof(States), name);
        }
        public abstract string GetShape();
        public abstract string GetCompression();
        public abstract string ParticleMovement();

        public virtual string GetData() => $"{Name} {Mass} {State}";
    }
}
