using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms.VisualStyles;

namespace Curs_2_Colorarea
{
    internal class Graf
    {
        public List<Vertex> Vertices;
        public List<Edge> Edges;
        public Graf()
        {
            Vertices = new List<Vertex>();
            Edges = new List<Edge>();
        }

        public void LoadFromFile(string fileName)
        {
            TextReader reader = new StreamReader(fileName);
            int n = int.Parse(reader.ReadLine());
            string buffer;
            for(int i = 0; i < n; i++)
            {
                buffer = reader.ReadLine();
                Vertex local = new Vertex(buffer);
                Vertices.Add(local);
            }
        }
        public void Draw(Graphics h)
        {
            foreach(Vertex v in Vertices)
            {
                v.Draw(h);
            }
        }

    }
}
