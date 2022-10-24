using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs_2_Colorarea
{
    public static class Engine
    {
        //pt mod graphic
        public static Graphics grp;
        public static Bitmap bmp;
        public static PictureBox display;
        public static Color color = Color.BlanchedAlmond;
        public static Graf demo;
        public static Color[] Pall = new Color[] { Color.Red, Color.Blue, Color.Yellow, Color.Orange, Color.Orchid };

        public static void initGraph(PictureBox t)
        {
            display = t;
            bmp = new Bitmap(t.Width, t.Height);
            grp = Graphics.FromImage(bmp);
            grp.Clear(color);
        }

        public static void Refresh()
        {
            display.Image = bmp;
        }

        public static void Clear()
        {
            grp.Clear(color);
        }

        public static Vertex Search(string name, Graf g)
        {
            foreach (Vertex vertex in g.Vertices)
            {
                if (vertex.Name == name)
                    return vertex;
            }
            return null;
        }
    }

}
