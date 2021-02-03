using System;
namespace Inheritance
{
    public class Bird : Animal 
    {
        public Bird()
        {
            IsAlive = true;
            NumberOfLegs = 2;
            LandSeaAir = "Air";
            Age = 0;
        }

        public bool HasFeathers { get; set; }
        public bool HasBeak { get; set; }
        public string FeatherColor { get; set; }
        public bool LaysEggs { get; set; }


    }
}
