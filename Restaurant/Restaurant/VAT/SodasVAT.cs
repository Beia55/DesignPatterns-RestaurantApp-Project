using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.VAT
{
    public class SodasVAT : VAT
    {
        public SodasVAT(double price) : base(price)
        {
            base.Percentage = 12;
        }
    }
}