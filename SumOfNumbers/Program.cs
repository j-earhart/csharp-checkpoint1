using System;

namespace FactorialOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {


            var sum = 0;
            while (true)
            {
                Console.WriteLine("Enter a number or ok to exit:");
                String ans = Console.ReadLine();
                if (ans == "ok" || ans.ToLower() == "ok") break;
                sum += Convert.ToInt32(ans);
                Console.WriteLine("Sum: " + sum);
                Console.ReadLine();
            }


        }
    }
}
