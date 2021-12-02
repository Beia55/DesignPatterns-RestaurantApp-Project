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
    public class PizzaBuilder
    {
        public MenuItem _menuItem;
        public Order _order = Order.Instance;
        DataMenuItems _data = new DataMenuItems();

        public void BuildCapriciosa()
        {
            this._menuItem = new MenuItem(_data.CapriciosaPizza[0], Convert.ToDouble(_data.CapriciosaPizza[1]), _data.CapriciosaPizza[2], VATTypes.ForFOOD);
            this._order.AddMenuItem(this._menuItem);
        }

        public void BuildQuattroStagioni()
        {
            this._menuItem = new MenuItem(_data.QuattroStagioniPizza[0], Convert.ToDouble(_data.QuattroStagioniPizza[1]), _data.QuattroStagioniPizza[2], VATTypes.ForFOOD);
            this._order.AddMenuItem(this._menuItem);
        }

        public void BuildMargherita()
        {
            this._menuItem = new MenuItem(_data.MargheritaPizza[0], Convert.ToDouble(_data.MargheritaPizza[1]), _data.MargheritaPizza[2], VATTypes.ForFOOD);
            this._order.AddMenuItem(this._menuItem);
        }

        public void BuildProsciuto()
        {
            this._menuItem = new MenuItem(_data.ProsciutoEFunghiPizza[0], Convert.ToDouble(_data.ProsciutoEFunghiPizza[1]), _data.ProsciutoEFunghiPizza[2], VATTypes.ForFOOD);
            this._order.AddMenuItem(this._menuItem);
        }

    }
}
