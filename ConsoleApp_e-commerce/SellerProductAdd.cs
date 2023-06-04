using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    class SellerProductAdd : AbstractProductTransaction
    {
        public static Products products = new Products();

        public override void Execute()
        {
            products.ProductAdd();
        }

        public override void Undo()
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
