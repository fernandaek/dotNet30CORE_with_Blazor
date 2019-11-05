using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1.Classes.Chapter_11_Interfaces
{
    public interface IMatter
    {
         string Name { get; }
         double Mass { get; }
         States State { get; }

        string GetCompression();


        string GetShape();


        string ParticleMovement();
    }
   
}
