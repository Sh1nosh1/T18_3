using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T18_3
{
    internal class Program
    {
        enum Action { Create = 1, Remove, Update, Output, Exit }
        enum TypeOfFigure { Rectangle = 1, Square, Triangle, Circle, Exit }
        static void Main(string[] args)
        {
            try
            {
                FiguresRepository repository = new FiguresRepository();
                bool flag = true;
                while (flag)
                {
                    WriteLine("Choose an action: \n1 - Create Figure\n2 - Remove Figure\n3 - Update Figure\n4 - Output all information\n5 - Exit\n");
                    if (Enum.TryParse(ReadLine(), out Action choice))
                    {
                        switch (choice)
                        {
                            case Action.Create:
                                Clear();
                                WriteLine("Choose a type of figure: \n1 - Rectangle\n2 - Square\n3 - Triangle\n4 - Circle\n5 - Exit\n");
                                if (Enum.TryParse(ReadLine(), out TypeOfFigure type))
                                {
                                    switch (type)
                                    {
                                        case TypeOfFigure.Rectangle:
                                            repository.CreateFigure(Rectangle.Input());
                                            break;
                                        case TypeOfFigure.Square:
                                            repository.CreateFigure(Square.Input());
                                            break;
                                        case TypeOfFigure.Triangle:
                                            repository.CreateFigure(Triangle.Input());
                                            break;
                                        case TypeOfFigure.Circle:
                                            repository.CreateFigure(Circle.Input());
                                            break;
                                        case TypeOfFigure.Exit:
                                            Environment.Exit(0);
                                            break;
                                    }
                                }
                                else { Clear(); WriteLine("Wrong number! Try again.\n"); }
                                break;
                            case Action.Remove:
                                Clear();
                                Write("Enter the name of figure to remove: ");
                                string name = ReadLine();
                                repository.RemoveFigure(name.ToLower());
                                break;
                            case Action.Update:
                                Clear();
                                Write("Enter the name of figure to update: ");
                                string oldName = ReadLine();
                                Write("Enter the new figure: ");
                                WriteLine("Choose a type of figure: \n1 - Rectangle\n2 - Square\n3 - Triangle\n4 - Circle\n5 - Exit\n");
                                if (Enum.TryParse(ReadLine(), out TypeOfFigure typeFigure))
                                {
                                    Figure figure = null;
                                    switch (typeFigure)
                                    {
                                        case TypeOfFigure.Rectangle:
                                            figure = Rectangle.Input();
                                            break;
                                        case TypeOfFigure.Square:
                                            figure = Square.Input();
                                            break;
                                        case TypeOfFigure.Triangle:
                                            figure = Triangle.Input();
                                            break;
                                        case TypeOfFigure.Circle:
                                            figure = Circle.Input();
                                            break;
                                        case TypeOfFigure.Exit:
                                            Environment.Exit(0);
                                            break;
                                    }
                                    repository.UpdateFigure(oldName.ToLower(), figure);
                                    break;
                                }
                                break;
                            case Action.Output:
                                Clear();
                                foreach(var elem in repository.GetFigures()) { WriteLine(elem.ToString()); }
                                break;
                            case Action.Exit:
                                Environment.Exit(0);
                                break;
                        }
                    }
                    else { WriteLine("Wrong number! Try again.\n"); }
                }
            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }
    }
}
