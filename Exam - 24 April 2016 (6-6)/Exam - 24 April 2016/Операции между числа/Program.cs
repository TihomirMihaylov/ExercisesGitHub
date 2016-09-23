using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Операции_между_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();

            decimal result = 0;
            if (symbol=="+")
            {
                result = n1 + n2;
                Console.WriteLine("{0} {1} {2} = {3} - {4}",n1,symbol,n2,result, result%2==0 ? "even":"odd");
            }
            else if (symbol == "-")
            {
                result = n1 - n2;
                Console.WriteLine("{0} {1} {2} = {3} - {4}", n1, symbol, n2, result, result % 2 == 0 ? "even" : "odd");
            }
            else if (symbol == "*")
            {
                result = n1 * n2;
                Console.WriteLine("{0} {1} {2} = {3} - {4}", n1, symbol, n2, result, result % 2 == 0 ? "even" : "odd");
            }
            else if (symbol == "/")
            {
                if (n2 == 0)
                    Console.WriteLine("Cannot divide {0} by zero", n1);
                else
                {
                    result = (decimal)n1 / n2; //!!! Иска да го Cast-на
                    Console.WriteLine("{0} {1} {2} = {3:f2}", n1, symbol, n2,result);
                }
            }
            else if (symbol == "%")
            {
                if (n2 == 0)
                    Console.WriteLine("Cannot divide {0} by zero", n1);
                else
                {
                    result = n1 % n2;
                    Console.WriteLine("{0} {1} {2} = {3}", n1, symbol, n2, result);
                }
            }
        }
    }
}
