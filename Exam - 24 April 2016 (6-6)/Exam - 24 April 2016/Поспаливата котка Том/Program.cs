using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Поспаливата_котка_Том
{
    class Program
    {
        static void Main(string[] args)
        {
            int holidays = int.Parse(Console.ReadLine());

            int workdays = 365 - holidays;
            int playTimeWorkdays = workdays * 63;
            int playTimeHolidays = holidays * 127;
            int totalPlayTime = playTimeHolidays + playTimeWorkdays;
            int differenceMinutes = Math.Abs(totalPlayTime - 30000);
            int differenceInHours = differenceMinutes / 60;
            int differenceInMinutes = differenceMinutes % 60;
            
            if (totalPlayTime > 30000)
                Console.WriteLine("Tom will run away \n{0} hours and {1} minutes more for play",differenceInHours,differenceInMinutes);
            else
                Console.WriteLine("Tom sleeps well \n{0} hours and {1} minutes less for play", differenceInHours, differenceInMinutes);
        }
    }
}
