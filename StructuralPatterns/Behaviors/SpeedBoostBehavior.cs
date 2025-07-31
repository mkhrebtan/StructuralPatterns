using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StructuralPatterns.Abstraction;

namespace StructuralPatterns.Behaviors
{
    public class SpeedBoostBehavior : IBirdBehavior
    {
        public void Activate(Bird bird)
        {
            System.Console.WriteLine($"{bird.Name} activated speed boost!");
        }

        public string GetDescription()
        {
            return "Speed Boost Behavior: Increases speed temporarily.";
        }
    }
}