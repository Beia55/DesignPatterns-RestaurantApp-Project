using Restaurant.Menu.MenuBuilders;
using Restaurant.OrderCommand;
using Restaurant.StockDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menu
{
    public class MenuBuilder
    {
        public PizzaBuilder Pizza = new PizzaBuilder();
        public PastaBuilder Pasta = new PastaBuilder();
        public MeatBuilder Meat = new MeatBuilder();
        public SideDishBuilder SideDish = new SideDishBuilder();
        public DressingBuilder Dressing = new DressingBuilder();
        public DesertBuilder Desert = new DesertBuilder();
        public DrinksBuilder Drink = new DrinksBuilder();

        private IStockArgs model = ModelItemStock.Instance;
        public MenuBuilder()
        {
            model.InstantiateDrinkBuilder(this.Drink);
        }

        private Order _order = Order.Instance;
        
        public int ChangeIdOrder()
        {
            this._order.GetBillPerOrder();
            return this._order.ChangeCommadId();
        }

        public override string ToString()
        {
            return this._order.ToString();
        }
    }
}
