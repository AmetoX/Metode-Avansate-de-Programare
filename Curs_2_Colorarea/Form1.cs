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
            demo = new Graf();
            demo.LoadFromFile(@"C:\Users\Marius\Documents\.C#\An 2\Metode-Avansate-de-Programare\Curs_2_Colorarea\Planeta.txt");
            demo.Draw(Engine.grp);
            Engine.Refresh();
        }
    }
}