using System;

namespace GuidTutorial
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Creating a new Guid object
            Guid g = Guid.NewGuid();
            Console.WriteLine(g.ToString());      // Outputs an unique ID of 36 characters
            
            // To remove hyphens(-) from Guid string

            Console.WriteLine(g.ToString().Replace("-",string.Empty));

            Console.WriteLine(g.ToString("N"));  

            // To get a Guid string of limited characters (Can be used for password generation)

            Console.WriteLine(g.ToString("N").Substring(0,15));   // Substring(start_index, number of characters required)
        }
    }
}