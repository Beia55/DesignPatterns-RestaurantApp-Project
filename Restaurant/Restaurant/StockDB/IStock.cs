using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.StockDB
{
    public interface IStock
    {
        void GetData();
        void AddData(string type, int value);
    }
}
