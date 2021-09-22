using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
namespace ParallelFileSearch
{
    class Program
    {
        private static int totalSize;
        static void Main(string[] args)
        {
            if (!Directory.Exists(@"C:\training\Eurotraining\FileHandling"))
                { 
                Console.WriteLine("The directory does not exist."); 
                return;
            }
            String[] files = Directory.GetFiles(@"C:\training\Eurotraining\FileHandling"); 
            Parallel.For(0, files.Length, index => 
            { 
                FileInfo fi = new FileInfo(files[index]); 
                long size = fi.Length; 
                Interlocked.Add(ref totalSize, Convert.ToInt32(size));
            }); 
            Console.WriteLine("Directory '{0}':", "DirectoryName"); 
            Console.WriteLine("{0:N0} files, {1:N0} bytes", files.Length, totalSize);
            Console.Read();
        }
    }
}
