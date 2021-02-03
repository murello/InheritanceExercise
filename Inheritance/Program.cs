using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {






            

            


            var myBird = new Bird();
            myBird.HasBeak = true;
            myBird.HasFeathers = true;
            myBird.FeatherColor = "Blue";
            myBird.LaysEggs = true;



            var Lizard = new Reptile()
            {
                IsUgly = true,
                IsColdBlooded = true,
                HasScales = true,
                NumberofSpecies = 10

                
            };


            var myAnimals = new Animal[] { myBird, Lizard };

            foreach(var Animal in myAnimals)
            {
                Console.WriteLine($"Alive:{Animal.IsAlive}");
                Console.WriteLine($"Age:{Animal.Age}");
                Console.WriteLine($"It has {Animal.NumberOfLegs} legs.");
                Console.WriteLine($"It lives by {Animal.LandSeaAir}.");
            }
        }

    }
}
