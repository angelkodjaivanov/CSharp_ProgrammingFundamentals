using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoGallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int photoNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            double size = double.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int heigth = int.Parse(Console.ReadLine());
            string type, picType;
            

            if (size < 1000)
            {
                type = "B";
            }
            else if (size >= 1000 && size < 1000000)
            {
                size = size / 1000.0;
                type = "KB";
            }
            else
            {
                size = size / 1000000.0;
                type = "MB";
            }

            if (width == heigth)
            {
                picType = "square";
            }
            else if (width > heigth)
            {
                picType = "landscape";
            }
            else
            {
                picType = "portrait";
            }

            Console.WriteLine("Name: DSC_{0:D4}.jpg", photoNumber);
            Console.WriteLine("Date Taken: {0:D2}/{1:D2}/{2} {3:D2}:{4:D2}", day, month, year, hours, minutes );
            Console.WriteLine("Size: {0}{1}",size, type);
            Console.WriteLine("Resolution: {0}x{1} ({2})", width, heigth, picType);
        }
    }
}
