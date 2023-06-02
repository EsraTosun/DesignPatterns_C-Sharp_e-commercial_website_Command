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


        public static void MyBasketAdd()
        {
            Products products = new Products();

            products.amount = Products.productList[Customer.transactionID - 1000].amount;
            products.ID = Customer.transactionID;

            myBasketList.Add(products);
        }

        public static void MyBasketList()
        {
            for (int i = 0; i < myBasketList.Count; i++)
            {
                Customer.DesiredID = myBasketList[i].ID;
                products.FindingDesiredProduct();
            }

            MyBasketDelete();
        }

        public static void MyBasketDelete()
        {
            Console.WriteLine("If you want to remove it from mybasket, enter the index value");
            //Favorilerden çıkarmak isterseniz index değeri girin
            Console.WriteLine("If you do not want-enter the number -1");
            //İstemezseniz 100 sayısını giriniz
            int transaction = Convert.ToInt32(Console.ReadLine());

            if (transaction >= 0 && transaction < MyBasket.myBasketList.Count)
                MyBasket.myBasketList.RemoveAt(transaction);
        }
    }
}
