using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    class SellerProductDelete : AbstractProductTransaction
    {
        public static Products products = new Products();
        public static Seller seller = new Seller();

        public override void Execute()
        {
            try
            {
                seller.DeleteProduct();
            }
            catch (NotProductException e)
            {
                Console.WriteLine("Can't Add: " + e.Message);
            }
        }

        public override void Undo()
        {
            Products.productList.Add(Products.transactionProtucts);
        }
    }
}
