using Restaurant.OrderCommand;
using Restaurant.Resources;
using Restaurant.StockDB;
using Restaurant.VAT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menu.MenuBuilders
{
    public class DrinksBuilder
    {
        public MenuItem _menuItem;
        public Order _order = Order.Instance;
        DataMenuItems _data = new DataMenuItems();

        public string FruitType { get; set; }

        public void BuildWater()
        {
            this._menuItem = new MenuItem(_data.WaterDrink[0], Convert.ToDouble(_data.WaterDrink[1]), _data.WaterDrink[2], VATTypes.ForNATURALDRINK);
            this._order.AddMenuItem(this._menuItem);
        }

        public void BuildCola()
        {
            this._menuItem = new MenuItem(_data.ColaDrink[0], Convert.ToDouble(_data.ColaDrink[1]), _data.ColaDrink[2], VATTypes.ForSODAS);
            this._order.AddMenuItem(this._menuItem);
        }

        public void BuildFanta()
        {
            this._menuItem = new MenuItem(_data.FantaDrink[0], Convert.ToDouble(_data.FantaDrink[1]), _data.FantaDrink[2], VATTypes.ForSODAS);
            this._order.AddMenuItem(this._menuItem);
        }

        public void BuildLemonade(string type)
        {
            this.FruitType = type;
            this._menuItem = new MenuItem(this.FruitType.ToUpper()+" "+_data.LemonadeDrink[0], Convert.ToDouble(_data.LemonadeDrink[1]), _data.LemonadeDrink[2], VATTypes.ForNATURALDRINK);
            this._order.AddMenuItem(this._menuItem);
        }

        public void BuildFresh(string type)
        {
            this.FruitType = type;
            this._menuItem = new MenuItem(this.FruitType.ToUpper() + " " + _data.FreshDrink[0], Convert.ToDouble(_data.FreshDrink[1]), _data.FreshDrink[2], VATTypes.ForNATURALDRINK);
            this._order.AddMenuItem(this._menuItem);
        }

        public void BuildCoffee()
        {
            this._menuItem = new MenuItem(_data.CoffeeDrink[0], Convert.ToDouble(_data.CoffeeDrink[1]), _data.CoffeeDrink[2], VATTypes.ForNATURALDRINK);
            this._order.AddMenuItem(this._menuItem);
        }

    }
}
