using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        
        List<Point> vList;

        public VerticalLine(int x, int yHight, int yLow, char sym)
        {
            vList = new List<Point>();
            for (int y = yHight; y <= yLow; y++)
            {
                Point v = new Point(x, y, sym);
                vList.Add(v);
            }

        }

        public void Drow()
        {
            foreach (Point v in vList)
            {
                v.Draw();
            }
        }
    }
}
