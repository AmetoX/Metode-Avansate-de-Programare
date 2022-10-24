using System.Windows.Forms;

namespace Curs_2_Colorarea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graf demo;       
        private void Form1_Load(object sender, EventArgs e)
        {
            Engine.initGraph(pictureBox1);
            Engine.demo = new Graf();
            Engine.demo.LoadFromFile(@"../../../Planeta.txt");
            //Engine.demo.LoadFromFile(@"C:\Users\Marius\Documents\.C#\An 2\Metode-Avansate-de-Programare\Curs_2_Colorarea\Planeta.txt");
            Engine.demo.Color();
            List<string> t = Engine.demo.View(listBox2);
            Engine.demo.Draw(Engine.grp);
            Engine.Refresh();
        }
    }
}