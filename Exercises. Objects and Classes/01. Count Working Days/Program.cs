using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Count_Working_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            string startDateAsText = Console.ReadLine();
            string endDateAsText = Console.ReadLine();

            DateTime startDate = DateTime.ParseExact(startDateAsText, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(endDateAsText, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            int result = 0;
            while (startDate <= endDate)
            {
                if (startDate.DayOfWeek == DayOfWeek.Saturday || startDate.DayOfWeek == DayOfWeek.Sunday
                        || (startDate.Month == 1 && startDate.Day == 1)
                        || (startDate.Month == 3 && startDate.Day == 3)
                        || (startDate.Month == 5 && (startDate.Day == 1 || startDate.Day == 6 || startDate.Day == 24))
                        || (startDate.Month == 9 && (startDate.Day == 6 || startDate.Day == 22))
                        || (startDate.Month == 11 && startDate.Day == 1)
                        || (startDate.Month == 12 && (startDate.Day == 24 || startDate.Day == 25 || startDate.Day == 26)))           
                {
                   
                }
                else
                {
                    result++;
                }

                startDate = startDate.AddDays(1);

            }

            Console.WriteLine(result);

        }
    }
}
