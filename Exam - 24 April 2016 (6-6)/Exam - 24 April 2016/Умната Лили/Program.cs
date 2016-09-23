using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Умната_Лили
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double laundryMachinePrice=double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            double account = 0;
            double present = 10;

            for (int birthday = 1; birthday <= age; birthday++)
            {
                if (birthday % 2 == 1)
                    account += toyPrice;
                else
                {
                    account += present - 1;
                    present += 10;
                }
            }
            if (account >= laundryMachinePrice)
                Console.WriteLine("Yes! {0:f2}", account - laundryMachinePrice);
            else
                Console.WriteLine("No! {0:f2}", laundryMachinePrice - account);
        }
    }
}
