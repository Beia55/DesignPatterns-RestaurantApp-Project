using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.VAT
{
    public interface IVATSimpleFactory
    {
        double CreateVAT(VATTypes type, double price);
    }
}
