using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Classassignment
{
    public class Triangle:Shapes
    {
       
            int side1, side2,side3;
            Pen p;
            SolidBrush b;

            public void getValue(int[] data, Pen pen)
            {
                side1 = data[0];
                side2 = data[1];
                side3 = data[2];
                p = pen;
            }
            public void getValue(int[] data, SolidBrush brush)
            {
                side1 = data[0];
                side2 = data[1];
                side3 = data[2];

                b = brush;
            }


            public void Draw(Graphics G, int x_axis, int y_axis, bool turnfill)
            {

                Point p1 = new Point(x_axis,y_axis);
                Point p2 = new Point(side1,y_axis);

                Point p3 = new Point(side2,side3);

                Point[] points = { p1, p2, p3 };
                if (turnfill)
                {
                    G.FillPolygon(b, points);
                }
                else
                {
                    G.DrawPolygon(p, points);
                }
            }
        }
    }

