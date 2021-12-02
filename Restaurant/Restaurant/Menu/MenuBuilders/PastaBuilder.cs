using Restaurant.OrderCommand;
using Restaurant.Resources;
using Restaurant.VAT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menu.MenuBuilders
{
    public class PastaBuilder
    {
        public MenuItem _menuItem;
        public Order _order = Order.Instance;
        DataMenuItems _data = new DataMenuItems();

        public void BuildCarbonara()
        {
            this._menuItem = new MenuItem(_data.CarbonaraPasta[0], Convert.ToDouble(_data.CarbonaraPasta[1]), _data.CarbonaraPasta[2], VATTypes.ForFOOD);
            this._order.AddMenuItem(this._menuItem);
        }

        public void BuildSeaFood()
        {
            this._menuItem = new MenuItem(_data.SeaFoodPasta[0], Convert.ToDouble(_data.SeaFoodPasta[1]), _data.SeaFoodPasta[2], VATTypes.ForFOOD);
            this._order.AddMenuItem(this._menuItem);
        }

        public void BuildGnochi() 
        {
            this._menuItem = new MenuItem(_data.GnochiPasta[0], Convert.ToDouble(_data.GnochiPasta[1]), _data.GnochiPasta[2], VATTypes.ForFOOD);
            this._order.AddMenuItem(this._menuItem);
        }

        public void BuildQuattroFormaggi() 
        {
            this._menuItem = new MenuItem(_data.QuattroFormaggiPasta[0], Convert.ToDouble(_data.QuattroFormaggiPasta[1]), _data.QuattroFormaggiPasta[2], VATTypes.ForFOOD);
            this._order.AddMenuItem(this._menuItem);
        }

    }
}
