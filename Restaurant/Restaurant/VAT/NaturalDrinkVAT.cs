using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.VAT
{
    public class NaturalDrinkVAT : VAT
    {
        public NaturalDrinkVAT(double price) : base(price)
        {
            base.Percentage = 5;
        }
    }
}
