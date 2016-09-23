using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Стоп
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var dotsLeftRight = n;
            var dolna4erta = 2*n-1;

            Console.WriteLine("{0}{1}{0}",new string('.',n+1), new string('_', 2*n + 1));
            for (int row = 1; row <= n; row++)
            {
                Console.WriteLine("{0}//{1}\\\\{0}", new string('.', dotsLeftRight), new string('_', dolna4erta));
                dotsLeftRight--;
                dolna4erta += 2;
            }
            Console.WriteLine("//{0}STOP!{0}\\\\",new string('_',2*n-3));

            var dotsLeftRightBottom = 0;
            var dolna4ertaBottom = 4*n-1;

            for (int row = 1; row <= n; row++)
            {
                Console.WriteLine("{0}\\\\{1}//{0}", new string('.', dotsLeftRightBottom), new string('_', dolna4ertaBottom));
                dotsLeftRightBottom++;
                dolna4ertaBottom -= 2;
            }
        }
    }
}
