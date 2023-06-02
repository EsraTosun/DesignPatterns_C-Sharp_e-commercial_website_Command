using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    class CustomerListTransactions
    {
        static int transaction;

        public static  void MyBasketORFavoritesAdd()
        {
            Products products = new Products();

            Console.WriteLine("1 - MyBasket Add");
            Console.WriteLine("2 - Favorites Add");
            Console.WriteLine("Enter a number other than 1 and 2 to avoid action");
            //İşlem yapılmaması için 1 ve 2 dışında bir sayı giriniz
            transaction = Convert.ToInt32(Console.ReadLine());


            if (transaction == 1)
            {
                MyBasket.MyBasketAdd();
            }
            else if (transaction == 2)
            {
                Favorites.FavoritesAdd();
            }
            else
            {
                Console.WriteLine("The product has not been added");
                //Ürün eklenmedi
            }
        }
    }
}
