using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StructuralPatterns.Abstraction;

namespace StructuralPatterns.GameElements
{
    public class WoodBlock : GameElement
    {
        public WoodBlock() : base("Wood Block", 25) { }

        public override void Display(int indent = 0)
        {
            Console.WriteLine($"{new string(' ', indent)} {Name} (HP: {Health})");
        }
    }
}