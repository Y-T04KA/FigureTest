using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureTest
{
    public class SquareFinder
    {
        public double FindSquare(double arg1, double arg2, double arg3)
        {
            double[] a = { arg1, arg2, arg3 };
            Array.Sort(a);
            if (a[0]==0 && a[1]!=0)
            {
                //Console.WriteLine("wrong input");//writelin'ы можно перенести в основную часть
                return -1;
            }
            if (a[0] == 0 && a[1] == 0)
            {
                const double pi = 3.14159265359;
                double circle = pi * (a[2] * a[2]);
                //Console.WriteLine("it's a circle");
                return circle;
            } 
            else
            {
                double per = (arg1 + arg2 + arg3) / 2;
                double triangle = per*(per-arg1)*(per-arg2)*(per-arg3);
                int type = TriangleType(a);
                /*switch (type){
                    case 1:
                        Console.WriteLine("it's a right triangle");
                        break;
                    case 2:
                        Console.WriteLine("it's an acute triangle");
                        break;
                    case 3:
                        Console.WriteLine("it's an obtuse triangle");
                        break;
                    case -1:
                        Console.WriteLine("wrong input for triangle");
                        return -1;
                        
                }*/
                if (type == -1) return -1;
                return Math.Sqrt(triangle);
            }
        }
        private int TriangleType(double[] a)
        {
            if ((a[0] + a[1]) < a[2]) return -1;
            if ((a[1] - a[0]) > a[2]) return -1;
            if ((a[2] * a[2]) == (a[1] * a[1]) + (a[0] * a[0]))
            {
                return 1;
            }
            else if ((a[2] * a[2]) < (a[1] * a[1]) + (a[0] * a[0]))
            {
                return 2;
            }
            else return 3;

        }
    }
}
