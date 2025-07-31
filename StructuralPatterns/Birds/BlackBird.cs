using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StructuralPatterns.Abstraction;
using StructuralPatterns.Behaviors;

namespace StructuralPatterns.Birds
{
    public class BlackBird : Bird
    {
        public BlackBird() : base("Black Bird", "Black", 50, new ExplosiveBehavior())
        {

        }

        public override void Display()
        {
            Console.WriteLine($"⚫ {Name} - Power: {Power}");
            Console.WriteLine($"   Special Ability: {_behavior.GetDescription()}");
        }
    }
}