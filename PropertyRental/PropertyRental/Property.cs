using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyRental
{
    public enum TypeOfProperty
    {
        Appartment,
        SingleFamily,
        TownHouse,
        Unknown
    }
    public enum Condition
    {
        Excellent,
        Good,
        NeedsRepair,
        Unknown
    }
    [Serializable]
   public class Property
    {
        private long propCode;
        private TypeOfProperty tp;
        private Condition cond;
        private short beds;
        private float baths;
        private int levels;
        private decimal val;

        public long PropertyCode
        {
            get { return propCode; }
            set { propCode = value; }
        }

        public TypeOfProperty PropertyType
        {
            get { return tp; }
            set { tp = value; }
        }

        public Condition PropertyCondition
        {
            get { return cond; }
            set { cond = value; }
        }

        public short Bedrooms
        {
            get { return beds; }
            set { beds = value; }
        }
        public float Bathrooms
        {
            get { return (baths <= 0) ? 0.00f : baths; }
            set { baths = value; }
        }
        public int Stories
        {
            get { return levels; }
            set { levels = value; }
        }
        public decimal MonthlyRent
        {
            get { return (val <= 0) ? 0.00M : val; }
            set { val = value; }
        }
        public Property()
        {
            Random rnd = new Random();
            propCode = rnd.Next(100000, 999999);
            tp = TypeOfProperty.Unknown;
            beds = 0;
            baths = 0.0f;
            levels = 0;
            val = 0.00M;
        }
    }
}
