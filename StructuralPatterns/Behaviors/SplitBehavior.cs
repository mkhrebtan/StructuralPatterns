using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StructuralPatterns.Abstraction;

namespace StructuralPatterns.Behaviors
{
    public class SplitBehavior : IBirdBehavior
    {
        public void Activate(Bird bird)
        {
            System.Console.WriteLine($"{bird.Name} activated split behavior!");
        }

        public string GetDescription()
        {
            return "Split Behavior: Splits into multiple smaller birds.";
        }
    }
}