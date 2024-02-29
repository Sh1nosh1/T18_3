using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T18_3
{
    class Circle : Figure
    {
        /// <summary>
        /// Auto field - radius
        /// </summary>
        public double R {  get; set; }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Name of shape</param>
        /// <param name="radius">Radius</param>
        public Circle(string name, double radius) : base(name)
        {
            R = radius;
        }
        /// <summary>
        /// Area of circle
        /// </summary>
        /// <returns>Area</returns>
        public override double Area()
        {
            return Math.Pow(R, 2) * Math.PI;
        }
        /// <summary>
        /// Circle length
        /// </summary>
        /// <returns>length</returns>
        public override double Perimeter()
        {
            return 2 * Math.PI * R;
        }
        /// <summary>
        /// Output info
        /// </summary>
        public override string ToString()
        {
            return ($"Name: {Name}\nRadius: {R}\nArea: {Area()}\nPerimeter: {Perimeter()}\n");
        }
        /// <summary>
        /// Input info
        /// </summary>
        /// <returns>new Circle</returns>
        public static Square Input()
        {
            Write("Enter name of figure: ");
            string name = ReadLine();
            Write("Enter the radius: ");
            double radius = Convert.ToDouble(ReadLine());
            return new Square(name, radius);
        }

    }
}
