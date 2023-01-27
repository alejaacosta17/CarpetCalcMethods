using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CarpetCalcMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input for carpet size
            double length = getTotalDimension("lenght");
            double width = getTotalDimension("width");
            WriteLine("Length = {0:F2}, width = {1:F2}", length, width);
            double area = GetAreaInSqYards(length,width);
            WriteLine("Area in sq. yds = " + area.ToString("F2"));
          
        } //end of main method
        static double GetAreaInSqYards(double lengthX, double widthX)
        {
            const int SQFT_PER_SQYD = 9;
            double area = lengthX * widthX / SQFT_PER_SQYD;
            return area;

        }
        static double getTotalDimension(string carpetSide) 
        {
            Write("Please enter the " + carpetSide + " in feet");
            int feet = int.Parse(ReadLine());
            Write("Please enter the " + carpetSide + " in inches");
            int inches = int.Parse(ReadLine());
            double totalDimension = feet + (double)inches / 12;
            return totalDimension;
        }
    } //end of program class
} //end of namespace
