using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Classassignment
{
    public class Rectangle : Shapes
    {
        int length,breadth;
        Pen p;
        SolidBrush b;

        public void getValue(int[] data, Pen pen)
        {
            length = data[0];
            breadth = data[1];
            p = pen;
        }
        public void getValue(int[] data, SolidBrush brush)
        {
            length = data[0];
            breadth = data[1];
            b = brush;
        }


        public void Draw(Graphics G, int x_axis, int y_axis, bool turnfill)
        {
            if (turnfill)
            {
                G.FillRectangle(b, x_axis, y_axis, breadth, length);
            }
            else
            {
                G.DrawRectangle(p, x_axis, y_axis, breadth, length);
            }
        }
    }
}
