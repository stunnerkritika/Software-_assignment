using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Classassignment
{
    public interface Shapes
    {
      /// <summary>
      /// This method takes the brush and parameter and implements for other drawing
      /// </summary>
      /// <param name="param"></param>
      /// <param name="Brush"></param>
      void getValue(int[] param, SolidBrush Brush);
        /// <summary>
        /// This method takes the pen and parameter and implements for other drawing
        /// </summary>
        /// <param name="param"></param>
        /// <param name="pen"></param>
        void getValue(int[] param, Pen pen);

       
        /// <summary>
        /// This method takes the graphics int for initial position x and y ,bollean  for drwaing the shapes into the picture box.
        /// </summary>
        /// <param name="G"></param>
        /// <param name="Initial_position_x"></param>
        /// <param name="Initial_position_y"></param>
        /// <param name="filling"></param>
        void Draw(Graphics G, int Initial_position_x, int Initial_position_y, bool filling);
    }
}
