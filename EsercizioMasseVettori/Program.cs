using EsercizioMasseVettori.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioMasseVettori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double l = 400 * (Math.Pow(10, 6));
            Console.WriteLine(l);

            double m1 = 6 * Math.Pow(10, 24);
            double m2 = 7 * Math.Pow(10, 22);
            double m3 = 7 * Math.Pow(10, 22);
            double m4 = 7 * Math.Pow(10, 22);

            double G = 6.6743 * Math.Pow(10, -11);
            Console.WriteLine(G);

            Vector F21 = new Vector(G * m1 * m2 / (l * l), 0);
            Console.WriteLine("{0}, {1}", F21.X, F21.Y);

            Vector F31 = new Vector(0, G * m1 * m3 / (l * l));
            Console.WriteLine("{0}, {1}", F31.X, F31.Y);

            double mF41 = G * m1 * m4 / (2 * l * l);  //(Math.Pow(Math.Sqrt(2) * l, 2)
            Console.WriteLine(mF41);

            Vector F41x = new Vector(mF41 * Cos(45), 0);
            Console.WriteLine("{0}, {1}", F41x.X, F41x.Y);

            Vector F41y = new Vector(0, mF41 * Sin(45));
            Console.WriteLine("{0}, {1}", F41y.X, F41y.Y);

            Console.WriteLine("La componente risultate lungo la x è:{0}, " +
                "lungo la y:{1}", F21.X + F41x.X, (F31.Y + F41y.Y).ToString());

            Console.ReadLine();
        }

        private static double Cos(double x)
        {
            double y = Math.Cos(x * Math.PI/180);
            return y;
        }

        private static double Sin(double x)
        {
            double y = Math.Sin(x * Math.PI / 180);
            return y;
        }
    }
}
