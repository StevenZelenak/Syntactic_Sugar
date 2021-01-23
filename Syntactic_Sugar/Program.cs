using System;
using System.Collections.Generic;

namespace Syntactic_Sugar
{
    public class Bug
    {
        /*
            You can declare a typed public property, make it read-only,
            and initialize it with a default value all on the same
            line of code in C#. Readonly properties can be set in the
            class' constructors, but not by external code.
        */
        public string Name { get; } = "";
        public string Species { get; } = "";
        public List<string> Predators { get; } = new List<string>();
        public List<string> Prey { get; } = new List<string>();

        // Convert this readonly property to an expression member
        
        public string FormalName => $"{this.Name} the {this.Species}";
        

        // Class constructor
        public Bug(string name, string species, List<string> predators, List<string> prey)
        {
            this.Name = name;
            this.Species = species;
            this.Predators = predators;
            this.Prey = prey;
            Console.WriteLine(FormalName);
        }

        // Convert this method to an expression member
        public string PreyList() =>  string.Join(",", this.Prey);

        // Convert this method to an expression member
        public string PredatorList() => string.Join(",", this.Predators);


        // Convert this to expression method
        public string Eat(string food) => this.Prey.Contains(food) ? $"{this.Name} ate the {food}." : $"{this.Name} is still hungry.";
           
       
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Prey = new List<string>();
            Prey.Add("Thing1");
            Prey.Add("Thing2");
            Prey.Add("Thing3");

            List<string> Predator = new List<string>();
            Predator.Add("Enemy1");
            Predator.Add("Enemy2");
            Predator.Add("Enemy3");

            Bug bug1 = new Bug("Steven", "Humanoid", Predator, Prey);
            Console.WriteLine(bug1.PreyList());
            Console.WriteLine(bug1.PredatorList());
            Console.WriteLine(bug1.Eat("Thing1"));
            
           
        }
    }
}
