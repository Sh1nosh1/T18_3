using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T18_3
{
    class FiguresRepository
    {
        /// <summary>
        /// Colection of figures
        /// </summary>
        private List<Figure> figures = new List<Figure>();
        /// <summary>
        /// Add figure
        /// </summary>
        /// <param name="figure">Added figure</param>
        public void CreateFigure(Figure figure)
        {
            figures.Add(figure);
            WriteLine($"You have add a new figure - {figure.Name}\n");
        }
        /// <summary>
        /// Remove figure
        /// </summary>
        /// <param name="figure">Removed figure</param>
        public void RemoveFigure(string figure)
        {
            for (int i = figures.Count - 1; i >= 0; i--)
            {
                if (figures[i].Name == figure)
                {
                    figures.RemoveAt(i);
                    WriteLine($"You have removed a figure - {figure}\n");
                }
            }
            WriteLine("Figure not found\n");
        }
        /// <summary>
        /// Update 
        /// </summary>
        /// <param name="oldFigure">Old figure</param>
        /// <param name="newFigure">New figure</param>
        public void UpdateFigure(string oldFigure, Figure newFigure) 
        {
            for (int i = 0; i < figures.Count; i++)
            {
                if (figures[i].Name == oldFigure)
                {
                    figures[i] = newFigure;
                    WriteLine($"You have edited {oldFigure} to {newFigure.Name}\n");
                    return;
                }
            }
            WriteLine("Figure not found\n");
        }
        /// <summary>
        /// Get figures
        /// </summary>
        /// <returns>All figures in List</returns>
        public List<Figure> GetFigures()
        {
            return figures;
        }
    }
}
