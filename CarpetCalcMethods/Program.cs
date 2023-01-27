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
            double area = GetAreaInSqYards(length, width);
            WriteLine("Area in sq. yds = " + area.ToString("F2"));
            GetCarpetPrice("Berber", "Pile", out double berberPrice, out double pilePrice);
            WriteLine("Berber Price = {0:C}, Pile Price = {1:C}", berberPrice, pilePrice);
            double berberCost = GetCarpetCost(area, berberPrice);
            double pileCost = GetCarpetCost(area, pilePrice);
            WriteLine("Berber Cost = {0:C}, Pile Cost = {1:C}", berberCost, pileCost);
        } //end of main method
        static double GetCarpetCost(double area, double price) 
        {
            return area* price; //no local variable created, rturn can directly return a computation or result of operation
        }
        static void GetCarpetPrice(string carpetType1, string carpetType2, out double price1, out double price2)
        {
            Write("Enter the price for {0} carpet:", carpetType1);
            price1 = double .Parse(ReadLine());
            Write("Enter the price for {0} carpet:", carpetType2);
            price2 = double.Parse(ReadLine());
        }
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
