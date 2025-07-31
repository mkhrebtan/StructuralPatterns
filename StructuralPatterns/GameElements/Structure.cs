using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StructuralPatterns.Abstraction;

namespace StructuralPatterns.GameElements
{
    // Composite element
    public class Structure : GameElement
    {
        public override int Health
        {
            get
            {
                int totalHealth = 0;
                foreach (var element in _elements)
                {
                    totalHealth += element.Health;
                }
                return totalHealth;
            }
        }

        private List<GameElement> _elements = new List<GameElement>();

        public Structure(string name) : base(name)
        {
        }

        public void Add(GameElement element)
        {
            _elements.Add(element);
            if (_elements.Count == 1)
            {
                Health = element.Health; // Set initial health to the first element's health
            }
            else
            {
                Health += element.Health; // Increase health by the new element's health
            }
        }

        public void Remove(GameElement element)
        {
            _elements.Remove(element);
            if (_elements.Count == 0)
            {
                Health = 0; // No elements left, set health to 0
            }
            else
            {
                Health -= element.Health; // Decrease health by the removed element's health
            }
        }

        private Random _random = new Random();

        public override void TakeDamage(int damage)
        {
            System.Console.WriteLine($"{Name}:");

            double damageMultiplier = _random.NextDouble() * 0.5 + 0.5; // Random multiplier between 0.5 and 1.0
            int childDamage = (int)(damage * damageMultiplier);
            foreach (var element in _elements.ToList())
            {
                element.TakeDamage(childDamage);
                if (element.Health <= 0)
                {
                    Remove(element);
                }
            }

            if (Health <= 0)
            {
                Destroy();
            }
        }

        public override void Display(int indent = 0)
        {
            Console.WriteLine($"{new string(' ', indent)} {Name} (HP: {Health})");
            foreach (var element in _elements)
            {
                element.Display(indent + 4);
            }
        }
    }
}