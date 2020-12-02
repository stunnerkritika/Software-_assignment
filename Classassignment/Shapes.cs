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
        void getValue(int[] param, SolidBrush Brush);
        void getValue(int[] param, Pen pen);

        void Draw(Graphics G, int Initial_position_x, int Initial_position_y, bool filling);
    }
}
