using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T18_3
{
    abstract class Figure
    {
        /// <summary>
        /// Name of shape
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Constructor with 1 parameter
        /// </summary>
        /// <param name="name">Initializing name of shape</param>
        public Figure(string name) => Name = name;
        /// <summary>
        /// Abstract method for calculating area of shape
        /// </summary>
        /// <returns>Area of shape</returns>
        public abstract double Area();
        /// <summary>
        /// Abstract method for calculating perimeter of shape
        /// </summary>
        /// <returns>Perimeter of shape</returns>
        public abstract double Perimeter();
        /// <summary>
        /// Output information
        /// </summary>
        public abstract string ToString();

    }
}
