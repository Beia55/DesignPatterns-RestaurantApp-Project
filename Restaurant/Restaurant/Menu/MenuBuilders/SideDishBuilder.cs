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
    public class SideDishBuilder
    {
        public MenuItem _menuItem;
        public Order _order = Order.Instance;
        DataMenuItems _data = new DataMenuItems();

        public void BuildFrenchFries()
        {
            this._menuItem = new MenuItem(_data.FrenchFriessSideDish[0], Convert.ToDouble(_data.FrenchFriessSideDish[1]), _data.FrenchFriessSideDish[2], VATTypes.ForFOOD);
            this._order.AddMenuItem(this._menuItem);
        }

        public void BuildRice()
        {
            this._menuItem = new MenuItem(_data.RiceSideDish[0], Convert.ToDouble(_data.RiceSideDish[1]), _data.RiceSideDish[2], VATTypes.ForFOOD);
            this._order.AddMenuItem(this._menuItem);
        }

        public void BuildMashedPotatoes()
        {
            this._menuItem = new MenuItem(_data.MashedPotatoesSideDish[0], Convert.ToDouble(_data.MashedPotatoesSideDish[1]), _data.MashedPotatoesSideDish[2], VATTypes.ForFOOD);
            this._order.AddMenuItem(this._menuItem);
        }

    }
}
