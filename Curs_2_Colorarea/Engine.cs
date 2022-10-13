using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs_2_Colorarea
{
    public class Engine
    {
        //pt mod graphic
        public static Bitmap bmp;
        public static PictureBox display;
        public static Graphics grp;
        public static Color color = Color.BlanchedAlmond;
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
        public Vertex Search(string name, Graf g)
        {
            foreach (Vertex vertex in g.Vertices)
            {
                if (vertex.Name == name)
                {
                    return vertex;
                }
            }
            return null;
        }
    }

}
