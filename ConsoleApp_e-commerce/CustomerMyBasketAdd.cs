using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    class CustomerMyBasketAdd : AbstractProductTransaction
    {
        public static MyBasket myBasket = new MyBasket();

        public override void Execute()
        {
            myBasket.MyBasketAdd();
        }

        public override void Undo()
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
