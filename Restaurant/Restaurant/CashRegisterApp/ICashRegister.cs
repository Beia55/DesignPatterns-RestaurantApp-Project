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

        // Zice ca Pentru stocul de fructe, daca se gata trebuie sa fiu notificata, deci aici o sa folosesc observer pattern



        Bill CheckOut(List<MenuItem> order, int orderID); // Receive a bill from cash register per order

        // Aici am acum ca a iau fiecare Cart, ca sa il salvez in metoda si metoda sa calculeze toate id commands pe zi
        List<Bill> AddToBillsList(Bill bill);

        void PrintBills(); // Print all bills per day

        void PrintHistory(); //printing a daily history with all the items that were registered(name, quantity and price)

        double ShowTotalAmount(); // Showing at any moment what is the total amount of money in the register.
    }
}
