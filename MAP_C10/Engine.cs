using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MAP_C10
{
    public static class Engine
    {
        public static Graphics g;
        public static Bitmap bmp;
        public static PictureBox pictureBox;
        public static Color c;
        public static List<PointD> points;
        public static Random rnd = new Random();
        public static void InitGraph(PictureBox p)
        {
            pictureBox = p;
            bmp = new Bitmap(p.Width, p.Height);
            g = Graphics.FromImage(bmp);
        }
        public static void Init()
        {
            points = new List<PointD>();
            for (int i = 1; i <= 100; i++)
                points.Add(new PointD(rnd.Next(pictureBox.Width),
                    rnd.Next(pictureBox.Height)));
        }
        public static void Draw()
        {
            foreach (PointD p in points)
                p.Draw(g);
            Refresh();
        }
        public static void Clear()
        {
            g.Clear(c);
        }
        public static void Refresh()
        {
            pictureBox.Image = bmp;
        }
        public static double Distance(PointD A, PointD B)
        {
            return Math.Sqrt((A.x - B.x) * (A.x - B.x) + (A.y - B.y) * (A.y - B.y));
        }
    }
}
