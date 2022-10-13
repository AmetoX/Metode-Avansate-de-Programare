using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs_2_Colorarea
{
    internal class Edge
    {
        public Vertex Start;
        public Vertex End;
        public Edge(string data)
        {
            string[] buffer = data.Split(' ');
            Start = Engine.Search(buffer[0]);
        }
    }
}
