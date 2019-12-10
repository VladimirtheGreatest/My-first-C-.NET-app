using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("The current time is " + DateTime.Now);

                  int[] array1 = new int[] { 1, 3, 5, 7, 9 };

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] > 5)
                {
                    Console.WriteLine(array1[i]);
                }
            }
                        
           


        }
    }
}
