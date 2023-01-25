using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAP_C10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Engine.InitGraph(pictureBox1);
            Engine.Init();
            //Solution solution = new Solution();
            //solution.DrawSolution(Engine.g);
            //label1.Text = solution.CountPoints().ToString();
            Rezolvare test = new Rezolvare();
            test.Init();
            test.Sort();
            test.Draw(Engine.g);
            Engine.Draw();
            Engine.Refresh();
        }
    }
}
