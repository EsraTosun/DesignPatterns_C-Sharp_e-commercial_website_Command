using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    class SellerProductAdd : IProductTransaction
    {
        public static Products products = new Products();

        public void Execute()
        {
            products.ProductAdd();
        }

        public void Undo()
        {
            try
            {
                Seller.DesiredID = Products.transactionID;
                products.ProductDelete();
            }
            catch (NotProductException e)
            {
                Console.WriteLine("Can't Add: " + e.Message);
            }
        }
    }
}
