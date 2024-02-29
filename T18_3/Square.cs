using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T18_3
{
    class Square : Figure
    {
        /// <summary>
        /// Side of square
        /// </summary>
        public double Side { get; set; }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Name of shape</param>
        /// <param name="side">Side of square</param>
        public Square(string name, double side) : base(name)
        {
            Side = side;
        }
        /// <summary>
        /// Overriden method for calculating area of square
        /// </summary>
        /// <returns>Area</returns>
        public override double Area() { return Math.Pow(Side, 2); }
        /// <summary>
        /// Overriden method for calculating perimeter of square
        /// </summary>
        /// <returns>Perimeter</returns>
        public override double Perimeter() { return Side * 4; }
        /// <summary>
        /// Output info
        /// </summary>
        public override string ToString()
        {
            return ($"Name: {Name}\nSide: {Side}\nArea: {Area():f2}\nPerimeter: {Perimeter():f2}\n");
        }
        /// <summary>
        /// Input info
        /// </summary>
        /// <returns>New Square</returns>
        public static Square Input()
        {
            Write("Enter name of figure: ");
            string name = ReadLine();
            Write("Enter the side: ");
            double side = Convert.ToDouble(ReadLine());
            return new Square(name, side);
        }
    }
}
