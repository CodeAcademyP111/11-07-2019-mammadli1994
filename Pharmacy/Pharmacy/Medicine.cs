using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
   public class Medicine
    {
        private static int _id = 0;
        public int ID { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }

        public Medicine()
        {
            _id++;
            ID = _id;
        }
        public override string ToString()
        {
            return$"{ID} {Name} -{Price} AZN";
        }
    }
}
