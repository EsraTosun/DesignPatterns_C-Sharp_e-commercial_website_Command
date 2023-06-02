using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    class SellerProductDelete : ISellerProductTransaction
    {
        public static Products products = new Products();
        public static Seller seller = new Seller();

        public void Execute()
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

        public void Undo()
        {
            Products.productList.Add(Products.transactionProtucts);
        }
    }
}
