using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StructuralPatterns.Abstraction
{
    // Component interface
    public abstract class GameElement
    {
        public string Name { get; protected set; }
        public virtual int Health { get; protected set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }

        public GameElement(string name, int health = 100)
        {
            Name = name;
            Health = health;
        }

        public virtual void TakeDamage(int damage)
        {
            Health = Math.Max(0, Health - damage);
            Console.WriteLine($"{Name} took {damage} damage!");
            
            if (Health <= 0)
                Destroy();
        }

        public virtual void Destroy()
        {
            Console.WriteLine($"{Name} was destroyed!");
        }

        public abstract void Display(int indent = 0);
    }
}