using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillGeneration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of consumers:");
            int NumberOfConsumers = Convert.ToInt32(Console.ReadLine());
            List<ConsumerData> ListConsumer = new List<ConsumerData>();
            for (int i = 0; i < NumberOfConsumers; i++)
            {
                //ConsumerData cmd = new ConsumerData();
                Console.WriteLine("Enter Consumer number:");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Consumer name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Total units:");
                int units = Convert.ToInt32(Console.ReadLine());
                int cost = 10;
                int amt = cost * units;
                ListConsumer.Add(new ConsumerData(num,name,units,amt));
            }

            ConsumerFile.ConsumerFileWrite(ListConsumer);
            

            List<BillData> ListBill = new List<BillData>();
            for (int i = 0; i < NumberOfConsumers; i++)
            {
                Random r = new Random();
                int num = r.Next();
                num = num + ListConsumer[i].ConsumerNumber;
                DateTime date = new DateTime(2021, 09, 25);
                Console.WriteLine(date.ToString());
                ListBill.Add(new BillData(num, ListConsumer[i].ConsumerNumber, ListConsumer[i].TotalAmount,date.ToString()));
            }

            BillFile.BillFileWrite(ListBill);
            Console.Read();
        }
    }
}
