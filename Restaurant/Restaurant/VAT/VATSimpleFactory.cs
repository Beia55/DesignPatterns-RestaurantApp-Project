using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.VAT
{
    public class VATSimpleFactory : IVATSimpleFactory
    {
        public VAT FinalPriceWithVAT;

        public double CreateVAT(VATTypes type, double price)
        {
            switch (type)
            {
                case VATTypes.ForDESERT:
                    this.FinalPriceWithVAT = new DesertVAT(price);
                    return this.FinalPriceWithVAT.CalculateVTA();
                case VATTypes.ForNATURALDRINK:
                    this.FinalPriceWithVAT = new NaturalDrinkVAT(price);
                    return this.FinalPriceWithVAT.CalculateVTA();
                case VATTypes.ForSODAS:
                    this.FinalPriceWithVAT = new SodasVAT(price);
                    return this.FinalPriceWithVAT.CalculateVTA();
                default:
                    this.FinalPriceWithVAT = new FoodVAT(price);
                    return this.FinalPriceWithVAT.CalculateVTA();
            }
        }

        public override string ToString()
        {
            return "Init-Price: " + FinalPriceWithVAT.Price + " + " + FinalPriceWithVAT.Percentage + " % "
                + " = " + this.FinalPriceWithVAT.PriceWithVAT + " $ ";
        }
    }
}
