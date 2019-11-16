using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kumbara
{
    public class MadeniPara : Para
    {
        public double capi { get; set; }
        public double kalinligi { get; set; }
        public static double pi = 3.14;

        public override double HacipHesap()
        {
            return pi*capi *capi* kalinligi;
        }
    }
}
