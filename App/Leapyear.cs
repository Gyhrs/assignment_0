using System;

namespace App 
{
    public class Leapyear
    {
        public void promptUser()
        {
            Console.WriteLine("Type in a year to learn if it is a leapyear!");
            var input = Console.ReadLine();
            promptUser(input);
        }
        public void promptUser(String input)
        {
            try
            {
                int inputasint = Convert.ToInt32(input);
                if (isLeapYear(inputasint))
                {
                    Console.WriteLine("yay");
                } else 
                {
                    Console.WriteLine("nay");
                }
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
                promptUser();
            }
        }
        public bool isLeapYear(int year) 
        {
            if (year < 1582)
            {
                throw new ArgumentException("Year must be 1582 or higher");
            }
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