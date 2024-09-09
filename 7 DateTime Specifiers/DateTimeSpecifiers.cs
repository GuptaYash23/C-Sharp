using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // DateTime is build in class in C#
            DateTime dt = DateTime.Now;   // Returns the current date time

            Console.WriteLine(dt);        // Current Date Time  [dd-mm-yy h:m:s]
            Console.WriteLine("{0}",dt);  // Current Date Time  [dd-mm-yy h:m:s]

            // Using date format specifiers
            Console.WriteLine("{0:d}",dt);  // Current Date Time (Short format) [dd-mm-yy]

            Console.WriteLine("{0:D}",dt);  // Current Date Time (Long format) [dd-month-yy]

            Console.WriteLine("{0:f}",dt);  // Current Date Time (Full Date/Time short format) [dd-month-yy h:m]

            Console.WriteLine("{0:F}",dt);  // Current Date Time (Full Date/Time long format) [dd-month-yy h:m:s]

            Console.WriteLine("{0:g}",dt);  // General Date Time (Short format) [dd-month-yy h:m]

            Console.WriteLine("{0:G}",dt);  // General Date Time (Long format) [dd-month-yy h:m:s]

            Console.WriteLine("{0:m}",dt);  // Month [dd-Month]
            Console.WriteLine("{0:M}",dt);  // Month [dd-Month]

            Console.WriteLine("{0:t}",dt);  // Short Time [h:m]
            Console.WriteLine("{0:T}",dt);  // Long Time [h:m:s]

            Console.WriteLine("{0:y}",dt);  // Year Month [month year]
            Console.WriteLine("{0:Y}",dt);  // Year Month [month year]
            Console.WriteLine("{0:yy}",dt);  // Year [yy]

            Console.WriteLine("{0:ddd}",dt);   // Day (short format) [day - Tue]
            Console.WriteLine("{0:dddd}",dt);  // Day (long format) [day - Tuesday]

            Console.WriteLine("{0:HH}",dt);  // Hour [hh (24 hr format)]

            Console.WriteLine("{0:MM}",dt);  // Month(1-12) [mm]

            Console.WriteLine("{0:MMM}",dt);  // Month(short name) [month]

            Console.WriteLine("{0:ss}",dt);  // seconds(0-59) [ss]

            // Custom Format

            Console.WriteLine("{0:hh:mm:ss tt}",dt);  // 12 Hours format
            Console.WriteLine("{0:HH:mm:ss}",dt);     // 24 Hours format

            Console.WriteLine("{0:dd-MM-yyyy}", dt);  // dd-MM-yyyy format
            Console.WriteLine("{0:dd/MM/yyyy}", dt);  // dd-MM-yyyy format

        }
    }
}