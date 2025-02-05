using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введiть початкове значення Xmin: ");
            double cosinys = 1;
            string sxMin = Console.ReadLine();
            double xMin = Double.Parse(sxMin);
            Console.Write("Введiть кiнцеве значення Xmax: ");
            string sxMax = Console.ReadLine();
            double xMax = double.Parse(sxMax);
            Console.Write("Введiть прирiст dX: ");
            string sdx = Console.ReadLine();
            double dx = double.Parse(sdx);
            double x = xMin;
            double y;
            while (x <= xMax)
            {
                y = Math.Log(x*3)/Math.Pow(0.6 * x * Math.Sin(x*3) * Math.Cos(Math.Pow(x, 4)), 1.0 / 5.0);
                cosinys *= Math.Cos(y); 
                Console.WriteLine("x = {0}\t\t y = {1}", x, y);
                x += dx;
            }
            if (Math.Abs(x - xMax - dx) > 0.0001)
            {
                y = Math.Log(x*3)/Math.Pow(0.6 * x * Math.Sin(x*3) * Math.Cos(Math.Pow(x, 4)), 1.0 / 5.0);
                cosinys *= Math.Cos(y); 
                Console.WriteLine("x = {0}\t\t y = {1}", xMax, y);
            }
            Console.WriteLine(cosinys);
        }
    }
}


