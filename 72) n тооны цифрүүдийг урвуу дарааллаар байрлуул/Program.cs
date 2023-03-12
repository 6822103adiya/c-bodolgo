using System;
using System.Text;
//code by 103_dev
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Тоо оруул:");
        int number = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = number % 10;
            number /= 10;
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i]);
            if (i != numbers.Length - 1)
            {
                Console.Write(" ");
            }
        }

        Console.ReadLine();
    }
}
//Тоо өгөхдөө 123456 гэж өгсөн бол дараагийн тоо болох 7 гэж бичнэ үү 