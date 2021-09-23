using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BillGeneration
{
    class BillFile
    {
        public static void BillFileWrite(List<BillData> data)
        {
            FileStream fs = new FileStream(@"C:\training\Eurotraining\Hands on\HandsOn\BillGeneration\BillGeneration\BillFile.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sr = new StreamWriter(fs);
            for (int i = 0; i < data.Count; i++)
            {
                sr.WriteLine("Bill Number: " + data[i].BillNumber);
                sr.WriteLine("Consumer Number: " + data[i].ConsumerNumber);
                sr.WriteLine("Total amount: " +data[i].TotalAmount);
                sr.WriteLine(data[i].DueDate);
                sr.WriteLine();

            }
            sr.Close();
            fs.Close();
        }
    }
}
