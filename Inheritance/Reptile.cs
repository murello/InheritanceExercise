using System;
namespace Inheritance
{
    public class Reptile : Animal 
    {
        public Reptile()
        {
            IsAlive = true;
            Age = 0;
            LandSeaAir = "Land";
            NumberOfLegs = 4;

        }


        public bool IsUgly { get; set; }
        public int NumberofSpecies { get; set; }
        public bool HasScales { get; set; }
        public bool IsColdBlooded { get; set; }


    }
}
