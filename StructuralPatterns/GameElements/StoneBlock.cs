using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StructuralPatterns.Abstraction;

namespace StructuralPatterns.GameElements
{
    public class StoneBlock : GameElement
    {
        public StoneBlock() : base("Stone Block", 35) { }

        public override void Display(int indent = 0)
        {
            Console.WriteLine($"{new string(' ', indent)} {Name} (HP: {Health})");
        }
    }
}