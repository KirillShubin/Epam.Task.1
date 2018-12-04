using Epam.Task3.VectorGraphicsEditor.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.VectorGraphicsEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            FigureBase[] array = new FigureBase[5];
            array[0] = new Ring();
            array[1] = new Rectangle();
            array[2] = new Line();
            array[3] = new Round();
            array[4] = new Circle();

            foreach (var item in array)
            {
                item.Draw();

                //if (item is Line)
                //{
                //    var line = item as Line;
                //    line.LineGood();
                //}
            }
        }
    }
}
