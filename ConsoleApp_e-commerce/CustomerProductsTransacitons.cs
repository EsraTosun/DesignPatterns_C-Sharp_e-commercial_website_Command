using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    class CustomerProductsTransacitons
    {
		static Customer customer = new Customer();
		static User user = new User();

		public static IProductTransaction productTransaction;
		public static void CustomerAccount()    //Müşteri Hesabı
		{
			int transaction = -1;
			while (true)
			{
				Console.WriteLine("1- Account information"); //Hesap bilgileri
				Console.WriteLine("2- Products");  //Ürünlerini görüntüle
				Console.WriteLine("3- My Basket");   //Sepetim
				Console.WriteLine("4- Favorites");   //Favoriler
				Console.WriteLine("5- Payment");  //Ödeme
                Console.WriteLine("6- Undo");  //Geri Alma
                Console.WriteLine("7- Logout");  //Çıkış yap
				transaction = Convert.ToInt32(Console.ReadLine());

				if (transaction == (int)CustomerAccountType.AccountInformation)
				{
					customer.AccountInformation();
				}
				else if (transaction == (int)CustomerAccountType.Products)
				{
					customer.ProductsList();
				}
				else if (transaction == (int)CustomerAccountType.MyBasket)
				{
					customer.MyBaskets();
                    Console.WriteLine("If you want to remove it from mybasket, -1");
					int transac = Convert.ToInt32(Console.ReadLine());	
                    //Sepetten çıkarmak isterseniz -1 girin
                    if (transac == -1)
					{
                        productTransaction = new CustomerMyBasketDelete();
                        productTransaction.Execute();
                    }
                }
				else if (transaction == (int)CustomerAccountType.Favorites)
				{
					customer.Favoritess();
                    Console.WriteLine("If you want to remove it from mybasket, -1");
                    int transac = Convert.ToInt32(Console.ReadLine());
                    //Favorilerden çıkarmak isterseniz -1 girin
                    if (transac == -1)
                    {
                        productTransaction = new CustomerFavoritesDelete();
                        productTransaction.Execute();
                    }
                }
                else if (transaction == (int)CustomerAccountType.Payment)
                {
					if(User.login)
						customer.PaymentTransaction();

					else
						Console.WriteLine("Log in");  // Oturum aç
                }
				else if(transaction == (int)CustomerAccountType.Undo)
				{
					productTransaction.Undo();
				}
                else if (transaction == (int)CustomerAccountType.Logout)
				{
					return;
				}
			}
		}
	}
}
