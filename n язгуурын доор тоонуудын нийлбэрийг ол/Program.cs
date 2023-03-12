using System;
//error alert

namespace SumOfEvenNumbers
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

            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine("Язгуурын доор байгаа тоонуудын нийлбэр: {sum}");
            Console.ReadLine();
        }
    }
}
