using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StructuralPatterns.Abstraction;
using StructuralPatterns.Behaviors;

namespace StructuralPatterns.Birds
{
    public class RedBird : Bird
    {
        public RedBird() : base("Red Bird", "Red", 10, new PushBehavior())
        {

        }

        public override void Display()
        {
            Console.WriteLine($"🔴 {Name} - Power: {Power}");
            Console.WriteLine($"   Special Ability: {_behavior.GetDescription()}");
        }
    }
}