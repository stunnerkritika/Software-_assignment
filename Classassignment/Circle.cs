using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Classassignment
{
    public  class Circle :Shapes
    {
        int radius;
        Pen p;
        SolidBrush  b;

        public void getValue (int[] data , Pen pen)
        {
             radius = data[0];
                p = pen;
        }
        public void getValue(int[] data, SolidBrush brush)
        {
            radius = data[0];
            b = brush;
        }


    public void Draw (Graphics G , int x_axis , int y_axis, bool turnfill)
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
