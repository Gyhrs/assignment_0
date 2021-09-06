using System;

namespace App
{
    public class PromptUser
    {
        public static void Main(string[] args)
        {
            Leapyear leapyear = new Leapyear();
            try
            {
                 leapyear.promptUser();
            }
            catch (FormatException)
            {
                Console.WriteLine("Please write a real year");
                Main(args);
            }
        }
    }
}
