using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class Rectangular : Figure
    {
        private double _width;
        private double _length;

        public double Width
        {
            get { return _width; }
            set {
                if (value > 0)
                {
                    _width = value;
                }
                else
                {
                    Console.WriteLine("wrong input, width can't be negative");
                }
            }
        }

        public double Length
        {
            get { return _length; }
            set {
                if (value > 0)
                {
                    _length = value;
                }
                else
                {
                    Console.WriteLine("wrong input, length can't be negative");
                }
            }
        }

        public Rectangular(double widht, double length)
        {
            Width = widht;
            Length = length;
            
        }

        public override void CalcArea()
        {
            Console.WriteLine($"Area of rectangular : {Width * Length}");
        }
    }
}
