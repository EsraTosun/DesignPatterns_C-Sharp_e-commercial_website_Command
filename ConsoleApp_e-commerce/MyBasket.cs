using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    class MyBasket
    {
        public static List<Products> myBasketList = new List<Products>();
        public static Products products = new Products();

        public static MyBasket myBasket = new MyBasket();
        public static Products transactionProduct = new Products();
        public static int transactionIndex;
        public void MyBasketAdd()
        {
            Products products = new Products();

            products.amount = Products.productList[Customer.transactionID - 1000].amount;
            products.ID = Customer.transactionID;
            transactionIndex = myBasketList.Count;

            myBasketList.Add(products);
        }

        public static void MyBasketList()
        {
            for (int i = 0; i < myBasketList.Count; i++)
            {
                Customer.DesiredID = myBasketList[i].ID;
                products.FindingDesiredProduct();
            }
        }

        public void MyBasketDelete()
        {
            Console.WriteLine("If you want to remove it from mybasket, enter the index value");
            //Favorilerden çıkarmak isterseniz index değeri girin
            int transaction = Convert.ToInt32(Console.ReadLine());

            if (transaction >= 0 && transaction < MyBasket.myBasketList.Count)
            {
                transactionProduct = myBasketList[transaction];
                myBasketList.RemoveAt(transaction);
            }
            else
            {
                throw new NotProductException();
            }
        }
    }
}
