using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs_2_Colorarea
{
    public class Edge
    {
        public Vertex Start;
        public Vertex End;

        public Edge(string data)
        {
            string[] buffer = data.Split(' ');
            Start = Engine.Search(buffer[0], Engine.demo);
            End = Engine.Search(buffer[1], Engine.demo);
        }

        public void Draw(Graphics h)
        {
            h.DrawLine(Pens.Red, Start.Location, End.Location);
        }
    }
}