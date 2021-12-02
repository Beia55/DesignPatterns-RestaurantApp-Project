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
    public class DressingBuilder
    {
        public MenuItem _menuItem;
        public Order _order = Order.Instance;
        DataMenuItems _data = new DataMenuItems();

        public void BuildKetchup()
        {
            this._menuItem = new MenuItem(_data.KetchupDressing[0], Convert.ToDouble(_data.KetchupDressing[1]), _data.KetchupDressing[2], VATTypes.ForFOOD);
            this._order.AddMenuItem(this._menuItem);
        }

        public void BuildMayo()
        {
            this._menuItem = new MenuItem(_data.MayoDressing[0], Convert.ToDouble(_data.MayoDressing[1]), _data.MayoDressing[2], VATTypes.ForFOOD);
            this._order.AddMenuItem(this._menuItem);
        }

        public void BuildTzatziki()
        {
            this._menuItem = new MenuItem(_data.TzatzikiDressing[0], Convert.ToDouble(_data.TzatzikiDressing[1]), _data.TzatzikiDressing[2], VATTypes.ForFOOD);
            this._order.AddMenuItem(this._menuItem);
        }

    }
}
