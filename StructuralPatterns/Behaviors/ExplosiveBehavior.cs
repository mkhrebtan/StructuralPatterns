using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StructuralPatterns.Abstraction;

namespace StructuralPatterns.Behaviors
{
    public class ExplosiveBehavior : IBirdBehavior
    {
        public void Activate(Bird bird)
        {
            // Logic for explosive behavior activation
            Console.WriteLine($"{bird.Name} explodes!");
        }

        public string GetDescription()
        {
            return "Explosive behavior: causes damage to nearby objects.";
        }
    }
}