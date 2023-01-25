using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAP_C10
{
    public class Rezolvare
    {
        public List<Solution> sol;
        public Rezolvare()
        {
            sol = new List<Solution>();
        }
        public void Sort()
        {
            sol.Sort(delegate (Solution A, Solution B)
            { return B.CountPoints().CompareTo(A.CountPoints()); });
        }
        public void Draw(Graphics g)
        {
            sol[0].DrawSolution(g);
        }
        public void Init()
        {
            for (int i = 0; i < 2000; i++)
                sol.Add(new Solution());
        }
    }
}
