using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAP_C10
{
    public class PointD
    {
        public double x, y;
        public const int radius = 2;
        public bool visited = false;
        public PointD(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public void Draw(Graphics grp)
        {
            if (!visited)
                grp.DrawEllipse(Pens.Black, (int)x - radius, (int)y - radius,
                2 * radius + 1, 2 * radius + 1);
            else
            {
                grp.FillEllipse(Brushes.Red, (int)x - radius, (int)y - radius,
                2 * radius + 1, 2 * radius + 1);
                grp.DrawEllipse(Pens.Blue, (int)x - radius, (int)y - radius,
                2 * radius + 1, 2 * radius + 1);
            }
        }
    }
}
