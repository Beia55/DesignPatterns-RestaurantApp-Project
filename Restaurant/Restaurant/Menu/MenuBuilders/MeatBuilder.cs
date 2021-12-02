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
    public enum MeatType
    {
        Rare,
        Medium,
        WellCooked,
    }

    public class MeatBuilder
    {
        public MenuItem _menuItem;
        public SideDishBuilder _sideDishBuilder = new SideDishBuilder();
        DataMenuItems _data = new DataMenuItems();


        public Order _order = Order.Instance;

        public void AddSideDishType (string sideDishType)
        {
            if(sideDishType ==  _data.FrenchFriessSideDish[1])
            {
                _sideDishBuilder.BuildFrenchFries();
            } else if (sideDishType == _data.MashedPotatoesSideDish[1])
            {
                _sideDishBuilder.BuildMashedPotatoes();
            } else if (sideDishType == _data.RiceSideDish[1])
            {
                _sideDishBuilder.BuildRice();
            } else
            {
                Console.WriteLine("Sorry! It doesn't exist ! Default = " + _data.RiceSideDish);
                _sideDishBuilder.BuildRice();
            }
            /*Console.WriteLine(this._sideDishBuilder);*/
        }

        public void BuildChicken(string sideDishType)
        {
            this._menuItem = new MenuItem(_data.ChickenMeat[0], Convert.ToDouble(_data.ChickenMeat[1]), _data.ChickenMeat[2], VATTypes.ForFOOD);
            this.AddSideDishType(sideDishType);

            this._order.AddMenuItem(this._menuItem);
        }

        public void BuildDuck(MeatType type, string sideDishType)
        {
            this._menuItem = new MenuItem(type+" " + _data.DuckMeat[0], Convert.ToDouble(_data.DuckMeat[1]), _data.DuckMeat[2], VATTypes.ForFOOD);
            this.AddSideDishType(sideDishType);

            this._order.AddMenuItem(this._menuItem);
        }

        public void BuildHamburger(MeatType type, string sideDishType)
        {
            this._menuItem = new MenuItem(type+" " + _data.HamburgerMeat[0], Convert.ToDouble(_data.HamburgerMeat[1]), _data.HamburgerMeat[2], VATTypes.ForFOOD);
            this.AddSideDishType(sideDishType);

            this._order.AddMenuItem(this._menuItem);
        }

        public void BuildSteak(MeatType type, string sideDishType)
        {
            this._menuItem = new MenuItem(type+" "+ _data.SteakMeat[0], Convert.ToDouble(_data.SteakMeat[1]), _data.SteakMeat[2], VATTypes.ForFOOD);
            this.AddSideDishType(sideDishType);

            this._order.AddMenuItem(this._menuItem);
        }

        public void BuildPork(string sideDishType)
        {
            this._menuItem = new MenuItem(_data.PorkChopsMeat[0], Convert.ToDouble(_data.PorkChopsMeat[1]), _data.PorkChopsMeat[2], VATTypes.ForFOOD);
            this.AddSideDishType(sideDishType);

            this._order.AddMenuItem(this._menuItem);
        }

    }
}
