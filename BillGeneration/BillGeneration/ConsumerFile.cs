using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BillGeneration
{
    class ConsumerFile
    {
        public static void ConsumerFileWrite(List<ConsumerData> data)
        {
            FileStream fs = new FileStream(@"C:\training\Eurotraining\Hands on\HandsOn\BillGeneration\BillGeneration\ConsumerFile.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sr = new StreamWriter(fs);
            for (int i = 0; i < data.Count; i++)
            {
                sr.WriteLine("Consumer Number: "+data[i].ConsumerNumber);
                sr.WriteLine("Consumer Name: " + data[i].ConsumerName);
                sr.WriteLine("Total number of units: " + data[i].TotalUnits);
                sr.WriteLine("Unit Cost: " + data[i].UnitCost);
                sr.WriteLine("Total amount: " + data[i].TotalAmount);
                sr.WriteLine();

            }
            sr.Close();
            fs.Close();
        }
    }
}
