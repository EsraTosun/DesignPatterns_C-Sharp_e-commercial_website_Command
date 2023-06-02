using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    class Favorites
    {
        public static List<Products> favoritesList = new List<Products>();
        public static Products products = new Products();

        public static void FavoritesAdd()
        {
            Products products = new Products();

            products.amount = Products.productList[Customer.transactionID - 1000].amount;
            products.ID = Customer.transactionID;

            favoritesList.Add(products);
        }

        public static void FavoritesList()
        {
            for (int i = 0; i < favoritesList.Count; i++)
            {
                Customer.DesiredID = favoritesList[i].ID;
                products.FindingDesiredProduct();
            }
            FavoritesDelete();
        }

        public static void FavoritesDelete()
        {
            Console.WriteLine("If you want to remove it from favorites, enter the index value");
            //Favorilerden çıkarmak isterseniz index değeri girin
            Console.WriteLine("If you do not want enter the number -1");
            //İstemezseniz-1 sayısını giriniz
            int transaction = Convert.ToInt32(Console.ReadLine());

            if (transaction >= 0 && transaction < Favorites.favoritesList.Count)
                Favorites.favoritesList.RemoveAt(transaction);
        }
    }
}
