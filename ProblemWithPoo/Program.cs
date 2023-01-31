using ProblemWithPoo;
using System;
using System.Globalization;

namespace ProblemWittPoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variaveis 
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X");

            //entrada de dados
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y");

            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // processamento de dados
            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            //saída de dados
            Console.WriteLine($"Área do triângulo X = {areaX.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área do triângulo Y = {areaY.ToString("F3", CultureInfo.InvariantCulture)}");

            if (areaX > areaY)
            {
                Console.WriteLine("Área do triângulo X é a maior");
            }
            else
            {
                Console.WriteLine("Área do triângulo Y é a maior");
            }
        }
    }
}
