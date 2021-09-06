using System;

namespace App 
{
    public class Leapyear
    {
        public Leapyear() {}
        public Leapyear(int inputtedyear) {
            if (isLeapYear(inputtedyear))
            {
                Console.WriteLine("yay");
            } else
            {
                Console.WriteLine("nay");
            }
        }
        public bool isLeapYear(int year) 
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    return year % 400 == 0;
                }
                return true;
            } else
            {
                return false;
            }
        }
    }
}