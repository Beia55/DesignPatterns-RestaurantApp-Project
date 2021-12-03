using Restaurant.Menu.MenuBuilders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.StockDB
{
    public interface IStockArgs
    {
        DrinksBuilder InstantiateDrinkBuilder(DrinksBuilder drink);
        void Notify(string type);
    }
}
