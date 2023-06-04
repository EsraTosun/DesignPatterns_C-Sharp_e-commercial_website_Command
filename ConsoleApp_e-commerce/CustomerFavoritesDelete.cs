using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    class CustomerFavoritesDelete : AbstractProductTransaction
    {
        public static Favorites favorites = new Favorites();

        public override void Execute()
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

        public override void Undo()
        {
            Favorites.favoritesList.Add(MyBasket.transactionProduct);
        }
    }
}
