using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StructuralPatterns.Abstraction
{
    public abstract class Bird
    {
        public string Name { get; protected set; }
        public string Color { get; protected set; }
        public int Power { get; protected set; }

        protected IBirdBehavior _behavior;

        public Bird(string name, string color, int power, IBirdBehavior behavior)
        {
            Name = name;
            Color = color;
            Power = power;
            _behavior = behavior;
        }

        public void ActivateSpecialPower()
        {
            Console.WriteLine($"Activating {Name}'s special power...");
            _behavior.Activate(this);
        }

        public void Launch()
        {
            Console.WriteLine($"{Name} has been launched!");
        }

        public virtual void HitTarget(GameElement target)
        {
            Console.WriteLine($"{Name} hits the target!");
            target.TakeDamage(Power);
        }

        public abstract void Display();
    }
}