using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[3];

            try
            {
                arr[0] = 11;
                arr[1] = 22;
                arr[2] = 33;
                arr[3] = 44;

                foreach (int num in arr)
                {
                    Console.WriteLine(num);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Array's range is exceeded");
                Console.WriteLine(ex.Message);
            }
        }
    }
}