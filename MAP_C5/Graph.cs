using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAP_C5
{
    internal class Graph
    {
        public int n;
        public int[,] matrix;
        public int[,] mdrumuri;

        public void load(string fileName)
        {
            TextReader reader = new StreamReader(fileName);
            n = int.Parse(reader.ReadLine());

            matrix = new int[n + 1, n + 1];
            mdrumuri = new int[n + 1, n + 1];

            string buffer;
            while ((buffer = reader.ReadLine()) != null)
            {
                string[] t = buffer.Split(' ');
                int x = int.Parse(t[0]);
                int y = int.Parse(t[1]);
                matrix[x, y] = 1;
            }
        }
        public List<string> view(int[,] m)
        {
            List<string> list = new List<string>();
            string buffer;
            for (int i = 1; i <= n; i++)
            {
                buffer = "";
                for (int j = 1; j <= n; j++)
                {
                    buffer += m[i, j];
                }
                list.Add(buffer);
            }
            return list;
        }
        public void Roy_Warshall()
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                    mdrumuri[i, j] = matrix[i, j];
            }

            for (int k = 1; k <= n; k++)
            {
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        if (i != j)
                        {
                            if (mdrumuri[i, j] == 0)
                                mdrumuri[i, j] = mdrumuri[i, k] * mdrumuri[k, j];
                        }
                    }
                }
            }
        }
        public List<string> CTC()
        {
            List<string> ctc = new List<string>();
            int[] p = new int[n + 1];
            string buffer;

            for (int i = 1; i <= n; i++)
                p[i] = 0;
            for (int i = 1; i <= n; i++)
            {
                buffer = "";
                if (p[i] == 0)
                {
                    buffer += i + " ";
                    p[i] = 1;
                    for (int j = 1; j <= n; j++)
                        if (mdrumuri[i, j] * mdrumuri[j, i] == 1)
                        {
                            buffer += j + " ";
                            p[j] = 1;
                        }
                }
                if (buffer != "")
                    ctc.Add(buffer);
            }
            return ctc;
        }
    }
}
