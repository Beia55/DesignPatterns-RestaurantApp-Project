using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.VAT
{
    public abstract class VAT
    {
        public int Percentage { get; set; }

        public double Price { get; set; }

        public double PriceWithVAT { get; set; }

        public VAT(double price)
        {
            this.Price = price;
            this.CalculateVTA();
        }

        public double CalculateVTA() {
            this.PriceWithVAT = this.Price + (this.Percentage / 100.00) * this.Price;
            return this.PriceWithVAT;
        }

        /*public override string ToString() {
            return "Init-Price: " + this.Price + " + " + this.Percentage + " % "
                + " = " + this.CalculateVTA();
         }*/
    }
}
