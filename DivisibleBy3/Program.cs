using System;

namespace program4
{
    class Program
    {
        public static void Main()
        {
            int a, i, sum = 0;
            for (i = 1; i < 100; i++)
            {
                a = i % 3;

                if (a == 0)
                {

                    sum++;
                }
            }
            Console.WriteLine("Total count is " + sum);
            Console.ReadLine();
        }
    }
}
