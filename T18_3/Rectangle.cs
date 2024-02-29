using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T18_3
{
    class Rectangle : Figure
    {
        /// <summary>
        /// Auto fields - Sides of rectangle
        /// </summary>
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="name">Name of shape</param>
        /// <param name="side1">First side</param>
        /// <param name="side2">Second side</param>
        public Rectangle(string name, double side1, double side2) : base(name)
        {
            Side1 = side1; Side2 = side2;
        }
        /// Overriden method for calculating area
        /// </summary>
        /// <returns>Area of rectangle</returns>
        public override double Area() { return Side1 * Side2; }
        /// <summary>
        /// Overriden method for calculating perimeter
        /// </summary>
        /// <returns>Perimeter of perimeter</returns>
        public override double Perimeter() { return (Side1 + Side2) * 2; }
        /// <summary>
        /// Output info
        /// </summary>
        public override string ToString()
        {
            return ($"Name: {Name}\nFirst side: {Side1}\nSecond side: {Side2}\nArea: {Area():f2}\nPerimeter: {Perimeter():f2}\n");
        }
        /// <summary>
        /// Input info
        /// </summary>
        /// <returns>New Rectangle</returns>
        public static Rectangle Input()
        {
            Write("Enter name of figure: ");
            string name = ReadLine();
            Write("Enter first side: ");
            double side1 = Convert.ToDouble(ReadLine());
            Write("Enter second side: ");
            double side2 = Convert.ToDouble(ReadLine());
            return new Rectangle(name, side1, side2);
        }
    }
}
