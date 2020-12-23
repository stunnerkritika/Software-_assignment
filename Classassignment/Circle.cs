using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Classassignment
{
    public class Circle : Shapes
    {
        int radius;
        Pen p;
        SolidBrush b;
        /// <summary>
        /// This method  returns the int value and pen 
        /// </summary>
        /// <param name="data"></param>
        /// <param name="pen"></param>
        public void getValue(float[] data, Pen pen)
        {
            radius = (int)data[0];
            p = pen;
        }
        /// <summary>
        /// This method returns the int data and solidbrush
        /// </summary>
        /// <param name="data"></param>
        /// <param name="brush"></param>
        public void getValue(float[] data, SolidBrush brush)
        {
            radius = (int)data[0];
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
                G.FillEllipse(b, x_axis, y_axis, radius, radius);
            }
            else
            {
                G.DrawEllipse(p, x_axis, y_axis, radius, radius);
            }
        }
    }
}
