using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T18_3
{
    class Triangle : Figure
    {
        /// <summary>
        /// Auto fields
        /// </summary>
        public double Side1 {  get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        /// <param name="side3"></param>
        public Triangle(string name, double side1, double side2, double side3) : base(name)
        {
            if (side1 < (side2 + side3) && side2 < (side1 + side3) && side3 < (side1 + side2))
            {
                Side1 = side1;
                Side2 = side2;
                Side3 = side3;
            }
            else { Write($"Triangle doesn't exist."); }
        }
        /// <summary>
        /// Overriden method for calculating area of triangle
        /// </summary>
        /// <returns>Area</returns>
        public override double Area()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
        }
        /// <summary>
        /// Overriden method for calculating perimeter of triangle
        /// </summary>
        /// <returns>PErimeter</returns>
        public override double Perimeter()
        {
            return Side1 + Side2 + Side3;
        }
        /// <summary>
        /// Output info
        /// </summary>
        public override string ToString()
        {
            return ($"Name: {Name}\nFirst side: {Side1}\nSecond side: {Side2}\nThird side: {Side3}\nArea: {Area():f2}\nPerimeter: {Perimeter():f2}\n");
        }
        /// <summary>
        /// Input info
        /// </summary>
        /// <returns>new Triangle</returns>
        public static Triangle Input()
        {
            Write("Enter name of figure: ");
            string name = ReadLine();
            Write("Enter first side: ");
            double side1 = Convert.ToDouble(ReadLine());
            Write("Enter second side: ");
            double side2 = Convert.ToDouble(ReadLine());
            Write("Enter third side: ");
            double side3 = Convert.ToDouble(ReadLine());
            return new Triangle(name, side1, side2, side3);
        }
    }
}
