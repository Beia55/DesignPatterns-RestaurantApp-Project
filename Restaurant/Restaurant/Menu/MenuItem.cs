using Restaurant.VAT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Restaurant.Menu
{
    public class MenuItem
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public string Ingredients { get; set; }
        private VATSimpleFactory VATFactory;
        private VATTypes VATType { get; set; }
        public double FinalPrice { get; set; }

        public MenuItem(string name, double price, string ingredients, VATTypes vatType)
        {
            this.Name = name;
            this.Price = price;
            this.Ingredients = ingredients;
            this.VATType = vatType;

            this.VATFactory = new VATSimpleFactory();
            this.VATFactory.CreateVAT(vatType, price);            
            this.FinalPrice = this.VATFactory.CreateVAT(vatType, price);            
        }

        public override string ToString()
        {
            return "Name - "+this.Name + " at "+this.VATFactory.ToString()
                + "\n Ingredients: " + this.Ingredients + "\n type - " + this.VATType.ToString();
        }
    }
}
