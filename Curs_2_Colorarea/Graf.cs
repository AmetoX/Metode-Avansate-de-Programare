using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms.VisualStyles;

namespace Curs_2_Colorarea
{
    public class Graf
    {
        public List<Vertex> Vertices;
        public List<Edge> Edges;
        public int[,] Matrix;


        public Graf()
        {
            Vertices = new List<Vertex>();
            Edges = new List<Edge>();
        }

        public void LoadFromFile(string filename)
        {
            TextReader reader = new StreamReader(filename);

            int n = int.Parse(reader.ReadLine());
            Matrix = new int[n, n];

            string buffer;

            for (int i = 0; i < n; i++)
            {
                buffer = reader.ReadLine();
                Vertex local = new Vertex(buffer);
                local.Idx = i;
                Vertices.Add(local);
            }

            while ((buffer = reader.ReadLine()) != null)
            {
                Edge edge = new Edge(buffer);
                Edges.Add(edge);
            }

            reader.Close();

            foreach (Edge edge in Edges)
            {
                Matrix[edge.Start.Idx, edge.End.Idx] = 1;
                Matrix[edge.End.Idx, edge.Start.Idx] = 1;
            }
        }

        public List<string> View(System.Windows.Forms.ListBox A)
        {
            List<string> t = new List<string>();
            string b;
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                b = "";
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    b += Matrix[i, j];
                    b += " ";
                }
                t.Add(b);
                A.Items.Add(b);
            }
            return t;
        }

        public void Draw(Graphics h)
        {
            foreach (Vertex v in Vertices)
            {
                v.Draw(h);
            }
            foreach (Edge e in Edges)
            {
                e.Draw(h);
            }
        }

        public void Color()
        {
            int n = Vertices.Count;
            int[] colors = new int[n];

            for (int i = 0; i < n; i++)
            {
                colors[i] = -1;
            }

            colors[0] = 0;

            bool[] Lc = new bool[n];


            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Lc[j] = false;
                }

                for (int j = 0; j < n; j++)
                {
                    if (Matrix[i, j] != 0)
                    {
                        if (colors[j] != -1)
                        {
                            Lc[colors[j]] = true;
                        }
                    }
                }

                int idx = 0;

                while (Lc[idx])
                {
                    idx++;
                }

                colors[i] = idx;
            }

            for (int i = 0; i < n; i++)
            {
                Vertices[i].color = colors[i];
            }
        }
    }
}
