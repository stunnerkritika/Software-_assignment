﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Classassignment
{
    public class Triangle : Shapes
    {
        int side1, side2, side3;
        Pen p;
        SolidBrush b;
        /// <summary>
        /// This method takes the pen  and paremeter and implements for other drawing
        /// </summary>
        /// <param name="data"></param>
        /// <param name="pen"></param>

        public void getValue(float[] data, Pen pen)
        {
            side1 = (int)data[0];
            side2 = (int)data[1];
            side3 = (int)data[2];
            p = pen;
        }
        /// <summary>
        /// This method takes the pen  and paremeter and implements for other drawing
        /// </summary>
        /// <param name="data"></param>
        /// <param name="brush"></param>
        public void getValue(float[] data, SolidBrush brush)
        {
            side1 = (int)data[0];
            side2 = (int)data[1];
            side3 = (int)data[2];

            b = brush;
        }

        /// <summary>
        ///  This method takes the graphics int for initial position x and y for drawing the shapes into the picture box.
        /// </summary>
        /// <param name="G"></param>
        /// <param name="x_axis"></param>
        /// <param name="y_axis"></param>
        /// <param name="turnfill"></param>
        public void Draw(Graphics G, int x_axis, int y_axis, bool turnfill)
        {

            Point p1 = new Point(x_axis, y_axis);
            Point p2 = new Point(side1, y_axis);

            Point p3 = new Point(side2, side3);

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

