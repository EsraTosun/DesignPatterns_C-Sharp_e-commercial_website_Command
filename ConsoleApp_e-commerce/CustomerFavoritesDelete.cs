using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    class CustomerFavoritesDelete : IProductTransaction
    {
        public static Favorites favorites = new Favorites();

        public void Execute()
        {
            try
            {
                favorites.FavoritesDelete();
            }
            catch (NotProductException e)
            {
                Console.WriteLine("Can't Add: " + e.Message);
            }
        }

        public void Undo()
        {
            Favorites.favoritesList.Add(MyBasket.transactionProduct);
        }
    }
}
