using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberDivider
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Input number: ");
            number = Int32.Parse(Console.ReadLine());
            Algorithm_search_divider(number);
            Console.ReadLine();
        }
        static void Algorithm_search_divider(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if(n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
