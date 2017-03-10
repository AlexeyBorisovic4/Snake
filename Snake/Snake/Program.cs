using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

           
                      
            //Отрисовка рамки
            HorizontalLine upline = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downline = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftline = new VerticalLine(0, 0, 24, '+');
            VerticalLine rigthline = new VerticalLine(78, 0,24, '+');
            upline.Drow();
            downline.Drow();
            leftline.Drow();
            rigthline.Drow();

            //орисовка точки
            Point p = new Point(4, 5, '*');
            p.Draw();

            Console.ReadKey();
        }      
    }
}
