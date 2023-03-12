using System;

namespace SevenMultiples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("n тоог оруулна уу: ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.Write("Буруу утга орууллаа. n тоог дахин оруулна уу: ");
            }
            int product = 1;
            for (int i = 1; i <= n; i++)
            {
                if (i % 7 == 0)
                {
                    product *= i;
                }
            }
            Console.WriteLine("7-д хуваагдах тоонуудын үржвэр:");
            Console.ReadLine();
        }
    }
}
