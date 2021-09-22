using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace ParallelFileRead
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\training\Eurotraining\FileHandling\networklog.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            Console.WriteLine("ID\t\tSource\t\t\tDestination\t\tDate\t\t\tStatus\t\tNetwork\tThread");

            Dictionary<int, string> d = new Dictionary<int, string>();
            Parallel.ForEach(File.ReadLines(@"C:\training\Eurotraining\FileHandling\networklog.txt"),(line,_,lineNumber) =>
                {
                   
                    d.Add(Convert.ToInt32(lineNumber), line);
                  
                });
            int j = 0;
            for (int i = 0; i <d.Count; i++)
            {
                //Console.WriteLine(d[i]);
                
                if (j == 6)
                {
                    j = 0;
                    Console.WriteLine();
                    continue;
                }
                string[] line = d[i].Split(':');
                Console.Write(line[1] + "\t\t");
                j++;
                //Thread.Sleep(500);
            }
           
            //Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            //Console.WriteLine();
            //sr.ReadLine();


            Console.Read();
        }
    }
}
