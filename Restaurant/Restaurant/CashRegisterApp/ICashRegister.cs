using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Menu;
using Restaurant.OrderCommand;

namespace Restaurant.CashRegisterApp
{
    public interface ICashRegister
    {

        Bill CheckOut(List<MenuItem> order, int orderID);

        List<Bill> AddToBillsList(Bill bill);

        void PrintBills(); // Print all bills per day - NOT IMPLEMENTED YET

        void PrintHistory();

        double ShowTotalAmount();
    }
}
