using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.VectorGraphicsEditor.Figures
{
    public abstract class FigureBase
    {
        public virtual int X { get; set; }
        public virtual int Y { get; set; }
        public abstract void Draw();
    }
}
