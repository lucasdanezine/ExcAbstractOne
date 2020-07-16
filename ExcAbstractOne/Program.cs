using System;
using ExcAbstractOne.Entities;
using ExcAbstractOne.Entities.Enums;
using System.Collections.Generic;
using System.Globalization;
namespace ExcAbstractOne
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> figura = new List<Shape>();

            Console.WriteLine("Entre com o número de figuras");
            int n = int.Parse(Console.ReadLine());
            
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rentangulo ou Circulo (r/c)? ");
                string resp = Console.ReadLine();
                Console.Write("Cor (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (resp == "r")
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    figura.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    figura.Add(new Circle(radius, color));
                }


               
            }

            Console.WriteLine("AREA DAS FIGURAS: ");

            foreach(Shape fig in figura)
            {
                Console.WriteLine(fig.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
