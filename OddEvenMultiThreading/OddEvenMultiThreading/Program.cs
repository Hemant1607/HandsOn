using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace OddEvenMultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            OddEven oddeven = new OddEven();
            Thread t1 = new Thread(oddeven.OddSum);
            Thread t2 = new Thread(oddeven.EvenSum);

            t1.Start(num);
            t2.Start(num);
            Console.Read();

        }
        
    }
    public class OddEven
    {
        public void OddSum(Object num)
        {
            int n = Convert.ToInt32(num);
            Parallel.For(0, n + 1, i =>
            {
                if (!(i % 2 == 0))
                {
                    Console.WriteLine($"Odd: {i}");
                }
            });
        }

        public void EvenSum(Object num)
        {
            int n = Convert.ToInt32(num);
            Parallel.For(0, n + 1, i =>
            {
                if ((i % 2 == 0))
                {
                    Console.WriteLine($"Even: {i}");
                }
            });
        }
    }

    

        
    
}
