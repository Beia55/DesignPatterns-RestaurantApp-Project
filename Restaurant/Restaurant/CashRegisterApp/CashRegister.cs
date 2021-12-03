using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Menu;
using Restaurant.OrderCommand;

namespace Restaurant.CashRegisterApp
{
    public class Bill
    {

        public int OrderID { get; set; }
        public List<MenuItem> _listMenuItems;
        public double TotalPrice { get; set; }

        public Bill(List<MenuItem> listMenuItems)
        {
            this._listMenuItems = listMenuItems;
        }

        public override string ToString()
        {
            int index = 0;
            return "Order ID: "+OrderID + "\n Items: \n" +
                string.Join(",\n    --->    Item-"+ (index++), this._listMenuItems);
        }
    }

    public class CashRegister : ICashRegister
    {
        private static readonly object _lockObject = new object();
        private static CashRegister _cashRegister;
        private static int _counter = 0;

        public Bill bill;
        public List<Bill> BillsList = new List<Bill>();

        private CashRegister()
        {   }

        public static CashRegister Instance
        {
            get
            {
                if (_cashRegister == null)
                {
                    lock (_lockObject)
                    {
                        if (_cashRegister == null)
                        {
                            _cashRegister = new CashRegister();
                            _counter++;
                        }
                    }
                }
                return _cashRegister;
            }
        }

        public Bill CheckOut(List<MenuItem> order, int orderID)
        {
            //
            bill = new Bill(order);
            bill.OrderID = orderID;
            bill.TotalPrice = bill._listMenuItems.Sum(x => x.FinalPrice);
            //

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n\n -----> Bill ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("from Cash Register for Order ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(bill.OrderID + "\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("   Items:");
            bill._listMenuItems.ForEach(x => Console.WriteLine("     *" + x.Name + " - " + x.FinalPrice + " RON "));
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(" ----------> TOTAL = " + bill.TotalPrice + " <---------- ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\n");

            this.AddToBillsList(bill);
            return bill;
        }

        public List<Bill> AddToBillsList(Bill bill)
        {
            this.BillsList.Add(bill);
            return this.BillsList;
        }

        public void PrintBills()
        {
            Console.WriteLine("Here, I will print the the all the bills per day");
        }

        public void PrintHistory()
        {
            Console.WriteLine("\n\n\n       ---------- > HISTORY < ----------       \n");
            /*this.BillsList.ForEach(x => Console.WriteLine("\n"+x.ToString()));*/
            /*this.BillsList.ForEach(x => Console.WriteLine("\n"+x.ToString()));*/
            foreach (var bill in this.BillsList)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n -----> Bill ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("from Cash Register for Order ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(bill.OrderID + "\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("   Items:");
                bill._listMenuItems.ForEach(x => Console.WriteLine("     *" + x.Name + " - " + x.FinalPrice + " RON "));
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write(" ----------> TOTAL = " + bill.TotalPrice + " <---------- ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("\n");
            }

            Console.WriteLine();
        }

        public double ShowTotalAmount()
        {
            double total = 0;
            foreach (var bill in this.BillsList)
            {
                total += bill.TotalPrice;
            }
            
            return total;
        }
        
    }
}
