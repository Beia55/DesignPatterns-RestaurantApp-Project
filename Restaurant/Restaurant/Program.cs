using System;
using Restaurant.CashRegisterApp;
using Restaurant.OrderCommand;
using Restaurant.StockDB;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock();

            // Create cart and add items to it
            Cart cart = new Cart();
            bool moreOrder = true;
            while (moreOrder == true)
            {
                cart.ChooseItems();
                Console.WriteLine("Do you want to make another order ? \n" +
                    "   Write - y - for YES \n     or \n   Write - n - for NO");
                string orderOption = Console.ReadLine();
                if(orderOption == "y" || orderOption == "Y")
                {
                    moreOrder = true;
                } else if (orderOption == "n" || orderOption == "N")
                {
                    moreOrder = false;
                } else
                {
                    Console.WriteLine("Invalid command! Default = end orders");
                    moreOrder = false;
                }

            }

            // Create Cash Register and use the functions of it
            CashRegister cash = CashRegister.Instance;
            cash.PrintHistory();
            Console.WriteLine("     ----------> Total Amount: "+cash.ShowTotalAmount() + " <----------      ");


            // Make the fill the fruit stock - ADMINISTRATOR RIGHTS
            Console.WriteLine("Do you want to fill the drink items stock ? \n" +
                "Write 1 for Yes and 2 for NO");
            var answer = Console.ReadLine();
            if(answer == "1")
            {
                Console.WriteLine("How many oranges ?");
                    var oranges = Console.ReadLine();
                    stock.AddData("oranges", Int32.Parse(oranges));

                Console.WriteLine("How many lemons ?");
                    var lemons = Console.ReadLine();
                    stock.AddData("lemons", Int32.Parse(lemons));

                    stock.GetData();
            } else
            {
                Console.WriteLine("--------------->     Program End     <---------------");
            }

        }
    }
}
