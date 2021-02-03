using System;

namespace Inheritance
{
    class Program
    {
        public class Animal
        {
            public int Age { get; set; }
            public int Height { get; set; }
            public int Width { get; set; }
            public bool BiggerThanBreadbox { get; set; }

        }

        public class Bird : Animal
        {
            public int Wingspan { get; set; }
            public int BeakLength { get; set; }
            public string SpeciesName { get; set; }
            public bool CanFly { get; set; }
        }
        public class Reptile : Animal
        {
            public int TailLength { get; set; }
            public int TeethCount { get; set; }
            public string Color { get; set; }
            public bool IsSnake { get; set; }
        }
        static void Main(string[] args)
        {
            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird crossbillFinch = new Bird()
            {
                Age = 1,
                Height = 2,
                Width = 1,
                BiggerThanBreadbox = false,
                Wingspan = 1,
                BeakLength = 1,
                SpeciesName = "Crossbill",
                CanFly = true
            };

            Reptile diamondbackSnake = new Reptile()
            {
                Age = 3,
                Height = 1,
                Width = 1,
                BiggerThanBreadbox = true,
                TailLength = 20,
                TeethCount = 2,
                Color = "Brown, Tan, Yellow",
                IsSnake = true,
            };
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Console.WriteLine($"This {crossbillFinch.SpeciesName} is {crossbillFinch.Age} years old. It has dimensions of {crossbillFinch.Height} inches tall and {crossbillFinch.Width} inches wide with an impressive wingspan of {crossbillFinch.Wingspan} inches and a mighty beak {crossbillFinch.BeakLength} centimeters long. If told that this gracious creature is larger than a breadbox, the statement is {crossbillFinch.BiggerThanBreadbox}");
        }
    }
}
