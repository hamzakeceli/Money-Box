using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kumbara
{
   public class KagitPara:Para
    {
        public double en { get; set; }
        public double boy { get; set; }
        public double yukseklik { get; set; }

        public override double HacipHesap()
        {
            return en*boy*yukseklik;
        }

        
    }
}
