using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ремонт_на_плочки
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte n = sbyte.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double l = double.Parse(Console.ReadLine());
            sbyte m = sbyte.Parse(Console.ReadLine());
            sbyte o = sbyte.Parse(Console.ReadLine());

            int area = n * n;
            int areaToBeCovered = area - m * o;
            double tileArea = w * l;
            double numTiles = areaToBeCovered / tileArea;
            double timeNeeded = numTiles * 0.2;
            Console.WriteLine("{0}\n{1}",numTiles,timeNeeded);
        }
    }
}
