﻿using System;

namespace _01.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] DaysOfWeek =
                {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
                };

            int day = int.Parse(Console.ReadLine());
            if (day >0 && day <8)
            {
            Console.WriteLine(DaysOfWeek[day-1]);

            }
            else
            {
                Console.WriteLine("Invalid day!");
            }




        }
    }
}