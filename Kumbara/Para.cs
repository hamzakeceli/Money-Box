using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kumbara
{
    public abstract class Para
    {
        public string adi { get; set; }
        public double degeri { get; set; }

        public abstract double HacipHesap();
      
    }
}
