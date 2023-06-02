using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    class CustomerMyBasketAdd : IProductTransaction
    {
        public static MyBasket myBasket = new MyBasket();

        public void Execute()
        {
            myBasket.MyBasketAdd();
        }

        public void Undo()
        {
            try
            {
                MyBasket.myBasketList.RemoveAt(MyBasket.transactionIndex);
            }
            catch (NotProductException e)
            {
                Console.WriteLine("Can't Add: " + e.Message);
            }
        }
    }
}
