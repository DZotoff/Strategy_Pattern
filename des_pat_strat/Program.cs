using des_pat_strat;
using System;
using System.Collections.Generic;

// Writing strategy interface
interface MoveStrat
{
    string Move();
}

// Concrete Strategies
class FlyStrat : MoveStrat
{
    public string Move()
    {
        return "FLIES BY FLAPPING WINGS";
    }
}

class NonFlyStrat : MoveStrat
{
    public string Move()
    {
        return "CANNOT FLY";
    }
}

class SwimStrat : MoveStrat
{
    public string Move()
    {
        return "SWIMS";
    }
}

class SlideStrat : MoveStrat
{
    public string Move()
    {
        return "SLIDES BY ITS BELLY";
    }
}

// Concrete Classes
class FlyingBird : Bird
{
    public FlyingBird(MoveStrat strategy) : base(strategy) { }

}

class NonFlyingBird : Bird
{
    public NonFlyingBird(MoveStrat strategy) : base(strategy) { }
}

class Program
{
    static void Main()
    {
        List<Bird> birds = new List<Bird>
        {
            new Duck { Name = "Mallard Duck", Color = "Brown" },
            new Eagle { Name = "Bald Eagle", Color = "White" },
            new Ostrich { Name = "Ostrich", Color = "Gray" },
            new Canary { Name = "Canary", Color = "Yellow" }
        };

        Console.WriteLine($"Number of birds in the simulation: {birds.Count}");

        foreach (var bird in birds)
        {
            bird.Move();
        }
    }
}





