using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GiaiPTBac2
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, x1, x2, delta;
            Console.WriteLine("nhap 3 so a,b,c: ");
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int c = Int32.Parse(Console.ReadLine());
            delta = (b * b) - (4 * a * c);
            if (a == 0)
            {
                if (b == 0 && c != 0)
                    Console.WriteLine("Phuong trinh vo nghiem");
                else
                {
                    x = -c / b;
                    Console.WriteLine("Phuong trinh co nghiem " + x.ToString());
                }
            }
            else
            {
                if (delta < 0)
                    Console.WriteLine("Phuong trinh vo nghiem");
                else if (delta == 0)
                {
                    x = -b / 2 * a;
                    Console.WriteLine("Phuong trinh co nghiem" + x.ToString());
                }
                else
                {
                    x1 = (-b - (float)Math.Sqrt(delta)) / 2 * a;
                    x2 = (-b + (float)Math.Sqrt(delta)) / 2 * a;
                    Console.WriteLine("PHuong trinh co nhiem thu nhat" + x1.ToString());
                    Console.WriteLine("Phuong trinh co nghiem thu hai" + x2.ToString());
                }
            }
            Console.ReadLine();
        }
    }
}