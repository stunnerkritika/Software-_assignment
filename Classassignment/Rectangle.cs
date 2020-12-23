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
        int length, breadth;
        Pen p;
        SolidBrush b;

        /// <summary>
        /// This method takes the pen  and paremeter and implements for other drawing
        /// </summary>
        /// <param name="data"></param>
        /// <param name="pen"></param>
        public void getValue(float[] data, Pen pen)
        {
            length = (int)data[0];
            breadth = (int)data[1];
            p = pen;
        }
        /// <summary>
        /// This method takes the solidbrush  and paremeter and implements for other drawing
        /// </summary>
        /// <param name="data"></param>
        /// <param name="brush"></param>
        public void getValue(float[] data, SolidBrush brush)
        {
            length = (int)data[0];
            breadth = (int)data[1];
            b = brush;
        }
        /// <summary>
        /// This methhod takes the graphics int for initial position x and y bollen for drawing the shapes into shapes into the picture box.
        /// </summary>
        /// <param name="G"></param>
        /// <param name="x_axis"></param>
        /// <param name="y_axis"></param>
        /// <param name="turnfill"></param>

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
