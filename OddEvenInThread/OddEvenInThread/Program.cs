using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace OddEvenInThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sequential Programming");
            DateTime now = DateTime.Now;
            for (int i = 0; i < value; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"Even: {i} Thread: {Thread.CurrentThread.ManagedThreadId}");
                }
                else
                {
                    Console.WriteLine($"Odd: {i} Thread: {Thread.CurrentThread.ManagedThreadId}");
                }
                Thread.Sleep(500);
            }
            DateTime now1 = DateTime.Now;
            TimeSpan intseq = now1 - now;
            Console.WriteLine("Milliseconds in sequential: {0}", intseq.TotalMilliseconds);
            //Console.WriteLine(now.ToString("dd MMM %d, yyyy"));
            //Console.WriteLine(now.ToString("hh:mm:ss tt"));
            Console.WriteLine("Parallel*****************************");
            DateTime now2 = DateTime.Now;
            Parallel.For(0, value, i =>
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"Even: {i} Thread: {Thread.CurrentThread.ManagedThreadId}");
                }
                else
                {
                    Console.WriteLine($"Odd: {i} Thread: {Thread.CurrentThread.ManagedThreadId}");
                }
                Thread.Sleep(500);
               
            });
            DateTime now3 = DateTime.Now;
            TimeSpan intpar = now3 - now2;
            Console.WriteLine("Milliseconds in parallel: {0}", intpar.TotalMilliseconds);
            Console.Read();
        }
    }
}
