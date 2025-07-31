using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StructuralPatterns.Abstraction;
using StructuralPatterns.Behaviors;

namespace StructuralPatterns.Birds
{
    public class BlueBird : Bird
    {
        public BlueBird() : base("Blue Bird", "Blue", 10, new SplitBehavior())
        {

        }

        public override void Display()
        {
            Console.WriteLine($"🔵 {Name} - Power: {Power}");
            Console.WriteLine($"   Special Ability: {_behavior.GetDescription()}");
        }
    }
}