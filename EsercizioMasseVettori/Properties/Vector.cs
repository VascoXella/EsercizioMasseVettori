using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioMasseVettori.Properties
{
    internal class Vector
    {
        public double X { get; }
        public double Y { get; }

        public Vector(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public Vector()
        {

        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            Vector v = new Vector(v1.X + v2.X, v1.Y + v2.Y);
            return v;
        }

        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector(v1.X - v2.X, v1.Y - v2.Y);

        }

        public static Vector operator -(Vector v)
        {
            Vector v1 = new Vector(-v.X, -v.Y);
            return v1;
        }

        public static Vector operator +(Vector v)
        {
            return v;
        }

        public static Vector operator *(Vector v1, Vector v2)
        {
            Vector v = new Vector(v1.X * v2.X, v1.Y * v2.Y);
            return v;
        }

        public static Vector operator *(Vector v1, double s)
        {
            Vector v = new Vector(v1.X * s, v1.Y * s);
            return v;
        }
        public static Vector operator *(double s, Vector v1)
        {
            return new Vector(v1.X * s, v1.Y * s);
        }

        public static Vector operator /(Vector v1, double s)
        {
            Vector v = v1 * (1 / s);
            return v;
        }

        public static Vector Parse(string s)
        {
            string[] parts = s.Split(';');
            Vector v = new Vector(double.Parse(parts[0]), double.Parse(parts[1]));
            return v;
        }


        public static Vector TryParse(string s, out Vector v)
        {
            try
            {
                v = Parse(s);
                return v;
            }
            catch
            {
                v = null;
                return v;
            }
        }

        public override string ToString()
        {
            return $"{X};{Y}";

        }



    }
}
