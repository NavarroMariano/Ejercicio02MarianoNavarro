using System;

namespace Ejercicio02MarianoNavarro
{
    class Program
    {
        static void Main(string[] args)
        {
			double a;
			double area;
			double b;
			double c;
			double perimetro;
			double semiperi;

			Console.WriteLine("Ingrese los Cm del 1er Lado");
			a = Double.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese los Cm del 2do Lado");
			b = Double.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese los Cm del 3er Lado");
			c = Double.Parse(Console.ReadLine());

			if (((a + b > c) || (a + c > b) || (b + c > a)) && (a >= 0 && b >= 0 && c >= 0))
			{
				semiperi = (a + b + c) / 2;
				area = Math.Sqrt(semiperi * (semiperi - a) * (semiperi - b) * (semiperi - c));
				perimetro = a + b + c;
				if ((Math.Pow(a, 2)) == ((Math.Pow(b, 2)) + (Math.Pow(c, 2))) || (Math.Pow(b, 2)) == ((Math.Pow(a, 2)) + (Math.Pow(c, 2))) || (Math.Pow(c, 2)) == ((Math.Pow(b, 2)) + (Math.Pow(a, 2))))
				{
					Console.WriteLine("Las medidas ingresadas pertenecen a un Triangulo RECTANGULO");
					Console.WriteLine($"El Perímetro del Triangulo es: {perimetro}Cm.");
					Console.WriteLine($"Cuya superficie abarca {area}cm2.");
				}
				else
				{
					if ((Math.Pow(a, 2)) > ((Math.Pow(b, 2)) + (Math.Pow(c, 2))) || (Math.Pow(b, 2)) > ((Math.Pow(a, 2)) + (Math.Pow(c, 2))) || (Math.Pow(c, 2)) > ((Math.Pow(b, 2)) + (Math.Pow(a, 2))))
					{
						Console.WriteLine("Las medidas ingresadas pertenecen a un Triangulo OBTUSÁNGULO");
						Console.WriteLine($"El Perímetro del Triangulo es: {perimetro}Cm.");
						Console.WriteLine($"Cuya superficie abarca {area}cm2.");
					}
					else
					{
						if ((Math.Pow(a, 2)) < ((Math.Pow(b, 2)) + (Math.Pow(c, 2))) || (Math.Pow(b, 2)) < ((Math.Pow(a, 2)) + (Math.Pow(c, 2))) || (Math.Pow(c, 2)) < ((Math.Pow(b, 2)) + (Math.Pow(a, 2))))
						{
							Console.WriteLine("Las medidas ingresadas pertenecen a un Triangulo ACUTÁNGULO");
							Console.WriteLine($"El Perímetro del Triangulo es: {perimetro}Cm.");
							Console.WriteLine($"Cuya superficie abarca {area}cm2.");
						}
						else
						{
							Console.WriteLine("Las medidas ingresadas no corresponden a un Triángulo");
						}
					}
				}
			}
			else
			{
				Console.WriteLine("Las medidas ingresadas no corresponden a un Triángulo");
			}
		}

	}

}

        }
    }
}
