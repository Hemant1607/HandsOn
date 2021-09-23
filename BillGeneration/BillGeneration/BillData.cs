using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillGeneration
{
    class BillData
    {
        public int BillNumber;
        public int ConsumerNumber;
        public int TotalAmount;
        public string DueDate;
   

        public BillData(int billnum,int ConNum,int Amount,string Date)
        {
            this.BillNumber = billnum;
            this.ConsumerNumber = ConNum;
            this.TotalAmount = Amount;
            this.DueDate = Date;
        }

        public int billnumber
        {
            get { return BillNumber; }
            set { BillNumber = value; }
        }
        public int Number
        {
            get { return ConsumerNumber; }
            set { ConsumerNumber = value; }
        }
        public int Amount
        {
            get { return TotalAmount; }
            set { TotalAmount = value; }
        }
        public string Duedate { 
            get { return DueDate; }
            set { DueDate = value; }
        }
    }
}
