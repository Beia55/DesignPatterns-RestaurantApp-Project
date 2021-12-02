using System;
using Restaurant.CashRegisterApp;
using Restaurant.OrderCommand;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            Cart cart = new Cart();
            cart.ChooseItems();
            cart.ChooseItems();

            CashRegister cash = CashRegister.Instance;
            cash.PrintHistory();
            Console.WriteLine(cash.ShowTotalAmount());
            
        }
    }
}
