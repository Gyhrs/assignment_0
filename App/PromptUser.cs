using System;

namespace App
{
    public class PromptUser
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Type in a year to learn if it is a leapyear!");
            var input = Console.ReadLine();
            int conv = Convert.ToInt32(input);
            var leapyearchecker = new Leapyear(conv);
        }
    }
}
