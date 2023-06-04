using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    class CustomerMyBasketDelete : AbstractProductTransaction
    {
        public static MyBasket myBasket = new MyBasket();

        public override void Execute()
        {
            try
            {
                myBasket.MyBasketDelete();
            }
            catch (NotProductException e)
            {
                Console.WriteLine("Can't Add: " + e.Message);
            }
        }

        public override void Undo()
        {
            MyBasket.myBasketList.Add(MyBasket.transactionProduct);
        }
    }
}
