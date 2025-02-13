//Малишева Валерія
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("Введiть початкове значення X1min: ");
        string sx1Min = Console.ReadLine();
        double x1Min = Double.Parse(sx1Min);
        Console.Write("Введiть кiнцеве значення X1max: ");
        string sx1Max = Console.ReadLine();
        double x1Max = double.Parse(sx1Max);
        Console.Write("Введiть прирiст dX1: ");
        string sdx1 = Console.ReadLine();
        double dx1 = double.Parse(sdx1);
        Console.Write("Введiть початкове значення X2min: ");
        string sx2Min = Console.ReadLine();
        double x2Min = Double.Parse(sx2Min);
        Console.Write("Введiть кiнцеве значення X2max: ");
        string sx2Max = Console.ReadLine();
        double x2Max = double.Parse(sx2Max);
        Console.Write("Введiть прирiст dX2: ");
        string sdx2 = Console.ReadLine();
        double dx2 = double.Parse(sdx2);
        double y;
        double x1 = x1Min;
        double x2;
        double cos_y;
        double cos_sum_y = 0;
        while (x1 <= x1Max)
        {
            x2 = x2Min;
            while (x2 <= x2Max)
            {
                y = Math.Pow(Math.Cos(x1), 3) + x2 / Math.Pow(x1, 13) + 3 / Math.Cos(x2) ;
                cos_y = Math.Cos(y);
                if (y < 0) cos_sum_y += cos_y;
                Console.WriteLine(
                    "x1 = {0:e}\tx2 = {1:e}\t\ty = {2:e}", x1, x2, y);
                x2 += dx2;
            }
            x1 += dx1;
        }
        Console.WriteLine("{0:e}",cos_sum_y);   
    }
}