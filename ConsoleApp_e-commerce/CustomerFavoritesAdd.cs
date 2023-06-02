﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    class CustomerFavoritesAdd : IProductTransaction
    {
        public static Favorites favorites = new Favorites();

        public void Execute()
        {
            favorites.FavoritesAdd();
        }

        public void Undo()
        {
            try
            {
                Favorites.favoritesList.RemoveAt(MyBasket.transactionIndex);
            }
            catch (NotProductException e)
            {
                Console.WriteLine("Can't Add: " + e.Message);
            }
        }
    }
}
