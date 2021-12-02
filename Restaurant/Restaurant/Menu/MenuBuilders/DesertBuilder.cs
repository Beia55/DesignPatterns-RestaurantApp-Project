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
    public class DesertBuilder
    {
        public MenuItem _menuItem;
        public Order _order = Order.Instance;
        DataMenuItems _data = new DataMenuItems();

        public void BuildLavaCake()
        {
            this._menuItem = new MenuItem(_data.LavaCakeDesert[0], Convert.ToDouble(_data.LavaCakeDesert[1]), _data.LavaCakeDesert[2], VATTypes.ForDESERT);

            this._order.AddMenuItem(this._menuItem);
        }

        public void BuildIcecream()
        {
            this._menuItem = new MenuItem(_data.IcecreamDesert[0], Convert.ToDouble(_data.IcecreamDesert[1]), _data.IcecreamDesert[2], VATTypes.ForDESERT);

            this._order.AddMenuItem(this._menuItem);
        }

    }
}
