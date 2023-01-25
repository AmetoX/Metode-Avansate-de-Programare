using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAP_C10
{
    public class Circle
    {
        public PointD centre;
        public const double radius = 50;
        public Circle()
        {

        }
        public Circle(double x, double y)
        {
            centre = new PointD(x, y);
        }
        public Circle(PointD centre)
        {
            this.centre = centre;
        }
        public void Draw(Graphics g)
        {
            g.DrawEllipse(Pens.Red, (int)(centre.x - radius), (int)(centre.y - radius),
                (int)radius * 2 + 1, (int)radius * 2 + 1);
        }
    }
    public class Solution
    {
        public Circle[] Points;
        public Solution()
        {
            Points = new Circle[5];
            for (int i = 0; i < Points.Length; i++)
            {
                Points[i] = new Circle();
                Points[i].centre = new PointD(Engine.rnd.Next(Engine.pictureBox.Width),
                    Engine.rnd.Next(Engine.pictureBox.Height));
            }
        }
        public void DrawSolution(Graphics g)
        {
            for (int i = 0; i < Points.Length; i++)
            {
                Points[i].Draw(g);
            }
        }
        public int CountPoints()
        {
            int s = 0;
            for (int i = 0; i < Engine.points.Count; i++)
            {
                Engine.points[i].visited = false;
            }
            for (int i = 0; i < Engine.points.Count; i++)
            {
                for (int j = 0; j < Points.Length; j++)
                {
                    if (Engine.Distance(Points[j].centre, Engine.points[i]) <=
                        Circle.radius)
                    {
                        s++;
                        Engine.points[i].visited = true;
                        break;
                    }
                }
            }
            return s;
        }
    }
}
