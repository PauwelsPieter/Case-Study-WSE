using System;
using System.Collections.Generic;

namespace Case_Study
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> Shapes = new List<Shape>();
            Shapes.Add(new Shape("rechthoek", "lengte", "breedte", "lengte * breedte"));
            Shapes.Add(new Shape("driehoek", "basis", "hoogte", "(basis * hoogte) / 2"));
            Shapes.Add(new Shape("cirkel", "straal", null, "straal * straal * pi"));

            double ShapeValueA = 0;
            double ShapeValueB = 0;


            //Show all possible shapes
            int counter = 1;
            foreach (Shape shape in Shapes) {
                Console.WriteLine(counter.ToString() + ". " + shape.getName());
                counter++;
            }

            //Ask which shape
            int ShapeNumber = -1;
            do {
                Console.Write("Van welke vorm wil je de oppervlakte berekenen? ");
                try {
                    ShapeNumber = Convert.ToInt32(Console.ReadLine());
                }
                catch {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nDe ingevoerde waarde is niet correct!");
                    Environment.Exit(1);
                }
            }
            while (ShapeNumber > Shapes.Count || ShapeNumber < 1);
            Shape ShapeSelected = Shapes[ShapeNumber-1];

            //Ask the value's needed to calculate the surface
            Console.WriteLine("\nEen " + ShapeSelected.getName() + " wordt op de volgende manier berekend: " + ShapeSelected.getCalculation());
            Console.Write(ShapeSelected.getValueA() + ": ");
            try {
                ShapeValueA = Double.Parse(Console.ReadLine());
            }
            catch {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nDe ingevoerde waarde is niet correct!");
                Environment.Exit(1);
            }
            if (ShapeSelected.getValueB() != null) {
                Console.Write(ShapeSelected.getValueB() + ": ");
                try {
                    ShapeValueB = Double.Parse(Console.ReadLine());
                }
                catch {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nDe ingevoerde waarde is niet correct!");
                    Environment.Exit(1);
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nDe berekende " + ShapeSelected.getName() + " heeft als oppervlakte: " + ShapeSelected.calculateResult(ShapeValueA, ShapeValueB));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nPress enter to exit.");
            Console.Read();
        }
    }
}