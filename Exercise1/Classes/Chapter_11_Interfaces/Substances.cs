﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1.Classes.Chapter_11_Interfaces
{
    public class Substances
    {
        private List<IMatter> Matters { get; } = new List<IMatter>();

        public string[] SateNames => Enum.GetNames(typeof(States));
        public States GetStateValue(string name) => (States)Enum.Parse(typeof(States), name);

        public Substances()
        {
            Add(new Solid("Ice", 0.9));
            Add(new Gas("Air", 0.1));
            Add(new Plasma("Lightning", 0.01));
            Add(new Liquid("Water", 1.0));
        }

        public void Add(IMatter matter) => Matters.Add(matter);
        public List<IMatter> Get() => Matters;
        public List<IMatter> Get(Func<IMatter, bool> expression) =>
            Matters.Where(expression).ToList();
    }
}
