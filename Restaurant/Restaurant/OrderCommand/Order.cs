using Restaurant.CashRegisterApp;
using Restaurant.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.OrderCommand
{
    public class Order
    {
        private static readonly object _lockObject = new object();
        private static Order _order;
        private static int _counter = 0;

        public int ClientId = 0;
        public int CopyClientId = 0;
        public int OrderItems = 0;
        public List<MenuItem> ListOrderedItems;

        public ICashRegister _cashRegister = CashRegister.Instance;

        private Order()
        {
            this.ListOrderedItems = new List<MenuItem>();
        }

        public static Order Instance
        {
            get
            {
                if (_order == null)
                {
                    lock (_lockObject)
                    {
                        if (_order == null)
                        {
                            _order = new Order();
                            _counter++;
                        }
                    }
                }
                return _order;
            }
        }

        public List<MenuItem> AddMenuItem(MenuItem item)
        {
            OrderItems++;

            if (CopyClientId == ClientId)
            {
                this.ListOrderedItems.Add(item);
            } else
            {
                this.ListOrderedItems.Clear();
                this.ListOrderedItems.Add(item);
            }

            CopyClientId = ClientId;

            return this.ListOrderedItems;
        }

        public void GetBillPerOrder()
        {
            _cashRegister.CheckOut(ListOrderedItems, ClientId);
            /*_cashRegister.AddToBillsList(_cashRegister.CheckOut(ListOrderedItems, ClientId));*/
        }

        public int ChangeCommadId()
        {
            OrderItems = 0;
            ClientId ++;
            return ClientId;
        }

        public override string ToString()
        {
            return "Clinet-ID: " + ClientId + " no of items = " + OrderItems + ": \n"
                + string.Join(", \n", this.ListOrderedItems);
        }
    }
}
