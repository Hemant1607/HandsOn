using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillGeneration
{
    class ConsumerData
    {
        public int ConsumerNumber;
        public string ConsumerName;
        public int TotalUnits;
        public int UnitCost = 10;
        public int TotalAmount;

        public ConsumerData(int ConNum,string name,int units,int amount)
        {
            this.ConsumerNumber = ConNum;
            this.ConsumerName = name;
            this.TotalUnits = units;
            this.TotalAmount = amount;
        }
       public int Number
        {
            get { return ConsumerNumber; }
            set { ConsumerNumber = value; }
        }
        public string name
        {
            get { return ConsumerName; }
            set { ConsumerName = value; }
        }
        public int units
        {
            get { return TotalUnits; }
            set { TotalUnits = value; }
        }
        public int amount
        {
            get { return TotalAmount; }
            set { TotalAmount = value; }
        }


    }
}
