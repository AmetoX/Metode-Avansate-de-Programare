using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs_2_Colorarea
{
    public class Vertex
    {
        public string Name;
        public PointF Location;
        public Vertex(string name, PointF location)
        {
            Name = name;
            Location = location; 
        }
        public Vertex(string data)
        {
            string[] t = data.Split(' ');
            Name = t[0].Trim();
            Location = new PointF(float.Parse(t[1]), float.Parse(t[2]));
        }
        public void Draw(Graphics h)
        {
            h.DrawEllipse(Pens.Black, Location.X - 5, Location.Y - 5, 11, 11);
            h.DrawString(Name, new Font("Arial", 12,FontStyle.Regular), new SolidBrush(Color.Blue),Location.X,Location.Y);
        }
    }
}
