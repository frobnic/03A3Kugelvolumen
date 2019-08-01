using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03A3Kugelvolumen
{
    class Program
    {
        static void Main(string[] args)
        {
            double diameter, surface, volume;
            double pi = Math.PI;

            Console.Write("Bitte erfassen Sie den Durchmesser in mm:");
            diameter = Convert.ToDouble(Console.ReadLine());

            surface = pi * Math.Pow(diameter,2);
            volume = (pi * Math.Pow(diameter,3)) / 6;

            Console.WriteLine("Oberfläche : {0:F2}", surface);
            Console.WriteLine("Volumen    : {0:F2}", volume);

        }
    }
}
