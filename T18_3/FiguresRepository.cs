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
        public List<Figure> GetFigures()
        {
            return figures;
        }
        /// <summary>
        /// Add figure
        /// </summary>
        /// <param name="figure">Figure</param>
        public void CreateFigure(Figure figure)
        {
            figures.Add(figure);
            WriteLine($"You have add a new figure - {figure.Name}\n");
        }
        /// <summary>
        /// Remove shape
        /// </summary>
        /// <param name="figure">Shape</param>
        public void RemoveFigure(string figure)
        {
            for (int i = figures.Count - 1; i >= 0; i--)
            {
                if (figures[i].Name == figure)
                {
                    figures.RemoveAt(i);
                    WriteLine($"You have removed a figure - {figure}\n");
                    return; // После удаления элемента нужно выйти из метода
                }
            }
            WriteLine("Figure not found\n");
        }
        /// <summary>
        /// Update 
        /// </summary>
        /// <param name="oldFigure">Old shape</param>
        /// <param name="newFigure">New shape</param>
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
    }
}
