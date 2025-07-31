using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StructuralPatterns.Abstraction;
using StructuralPatterns.Behaviors;

namespace StructuralPatterns.Birds
{
    public class YellowBird : Bird
    {
        public YellowBird() : base("Yellow Bird", "Yellow", 15, new SpeedBoostBehavior())
        {

        }

        public override void Display()
        {
            Console.WriteLine($"🟡 {Name} - Power: {Power}");
            Console.WriteLine($"   Special Ability: {_behavior.GetDescription()}");
        }
    }
}