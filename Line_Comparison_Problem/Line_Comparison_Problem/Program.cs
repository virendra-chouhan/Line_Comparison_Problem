﻿using System;

namespace Line_Comparison_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Line Comparison .");
            int x1, x2, y1, y2;
            Console.WriteLine("Enter values x1 and y1");
            //using type casting to convert to int
            x1 = Convert.ToInt32(Console.ReadLine());

            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter values x2 and y2");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("The length of the Line is : " + length);
        }
    }
}
