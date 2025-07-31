using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StructuralPatterns.Abstraction;

namespace StructuralPatterns.Behaviors
{
    public class PushBehavior : IBirdBehavior
    {
        public void Activate(Bird bird)
        {
            System.Console.WriteLine($"{bird.Name} pushed the blocks in the way!");
        }

        public string GetDescription()
        {
            return "Push Behavior: Pushes blocks in the way.";
        }
    }
}