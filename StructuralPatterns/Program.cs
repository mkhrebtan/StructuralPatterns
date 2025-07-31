using System;
using System.Collections.Generic;
using StructuralPatterns.Abstraction;
using StructuralPatterns.Birds;
using StructuralPatterns.GameElements;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Angry Birds Console Prototype");
        Console.WriteLine("============================\n");

        // Create birds with their default behaviors
        List<Bird> birds = new List<Bird>
        {
            new RedBird(),
            new BlackBird(),
            new YellowBird(),
            new BlueBird(),
        };

        // Display all available birds
        Console.WriteLine("Available Birds:");
        Console.WriteLine("-----------------");
        foreach (var bird in birds)
        {
            bird.Display();
            Console.WriteLine();
        }

        // Create a structure to attack
        var structure = CreatePigFortress();

        Console.WriteLine("\nPig Fortress:");
        Console.WriteLine("-----------------");
        structure.Display();

        foreach (var bird in birds)
        {
            AttackFortress(structure, bird);
            if (IsStructureDestroyed(structure))
            {
                Console.WriteLine($"\n{bird.Name} destroyed the Pig Fortress!");
                break;
            }
            else
            {
                Console.WriteLine($"\n{bird.Name} failed to destroy the Pig Fortress.");
            }
        }

        System.Console.WriteLine("Game Over!");
    }

    static Structure CreatePigFortress()
    {
        var fortress = new Structure("Pig Fortress");

        var base1 = new Structure("Base Layer");
        base1.Add(new StoneBlock());
        base1.Add(new StoneBlock());
        base1.Add(new WoodBlock());

        var middle = new Structure("Middle Layer");
        middle.Add(new GlassBlock());
        middle.Add(new Pig());
        middle.Add(new GlassBlock());

        var top = new Structure("Top Layer");
        top.Add(new WoodBlock());

        fortress.Add(base1);
        fortress.Add(middle);
        fortress.Add(top);

        return fortress;
    }
    
    static void AttackFortress(Structure fortress, Bird bird)
    {
        Console.WriteLine($"\nPlayer selects {bird.Name}");
        bird.Launch();
        bird.ActivateSpecialPower();
        bird.HitTarget(fortress);

        Console.WriteLine($"\nStructure after {bird.Name}'s attack:");
        fortress.Display();
    }

    static bool IsStructureDestroyed(Structure structure)
    {
        return structure.Health <= 0;
    }
}