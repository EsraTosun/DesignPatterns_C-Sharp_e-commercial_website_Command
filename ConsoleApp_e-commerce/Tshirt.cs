﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    class Tshirt : Products    //Tişört
    {
        public Tshirt()
            :base()
        {

        }

        public Tshirt(int UserId, int ID, String brand, int amount, String color, String productsType,
            String Patterns, String Bodys, String FabricType)
            : base(UserId, ID, brand, amount, color, productsType, Patterns, Bodys, FabricType)
        {

        }

        public override void SellerProductsList()  //Satıcı Ürünleri Listele
        {
            List<Products> result = productList.Where(x => x.UserID == User.USERID &&
             x.productType.Equals(Enum.GetName(typeof(ProductsType), 2))).ToList();
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }
        }

        public override void ProductsList()  //Ürünleri Listele
        {
            List<Products> result = productList.Where(
             x => x.productType.Equals(Enum.GetName(typeof(ProductsType), 2))).ToList();
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }
        }

        public override void ProductDelete()
        {
            int index = productList.FindIndex(r => r.ID == Seller.DesiredID &&
             r.productType.Equals(Enum.GetName(typeof(ProductsType), 2)));

            if (index >= 0) 
                productList.RemoveAt(index);
        }

        public override void FindingDesiredProduct()
        {
            List<Products> result = productList.Where(x => x.ID == Customer.DesiredID &&
             x.productType.Equals(Enum.GetName(typeof(ProductsType), 2))).ToList();
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
