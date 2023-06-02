using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp_e_commerce
{
    public enum ProductsType
    {
        allProduct,  //Tüm ürünler
        pants,       //pantolon
        tshirt,      //tişört
        dress        //elbise
    }

    class Products  //Ürünler
    {
        public static List<Products> productList = new List<Products>();

        public static List<String> ProductsTypelist = Enum.GetNames(typeof(ProductsType)).ToList();
        public int UserID;
        public int ID;
        public String brand;   //marka
        public int amount;   //tutar
        public String color;
        public String productType;

        public String patterns;   // boyu
        public String Bodys;      // bedeni
        public String FabricType;          // kumaşı

        public static Products transactionProtucts = new Products();
        public static int transactionID;
        int transaction;

 
        public Products()
        {

        }

        public Products(int UserId,int ID,String brand,int amount, String color,String productsType,
            String Patterns, String Bodys,String FabricType)
        {
            this.UserID = UserId;
            this.ID = ID;
            this.brand = brand;
            this.amount = amount;
            this.color = color;
            this.productType = productsType;
            this.patterns = Patterns;
            this.Bodys = Bodys;
            this.FabricType = FabricType;
        }

        public virtual void SellerProductsList()  //Satıcı Ürünleri Listele
        {
            List<Products> result = productList.Where(x => x.UserID == User.USERID).ToList();
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }
        }

        public virtual void ProductsList()  //Ürünleri Listele
        {
            for (int i = 0; i < productList.Count; i++)
            {
                Console.WriteLine(productList[i]);
            }
        }

        public virtual void FindingDesiredProduct()
        {
            List<Products> result = productList.Where(x => x.ID == Customer.DesiredID).ToList();
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }
        }

        public virtual void ProductDelete()
        {
            int index = productList.FindIndex(r => r.ID == Seller.DesiredID);
            if (index > -1)
            {
                transactionProtucts = productList[index];
                productList.RemoveAt(index);
            }
            else
            {
                throw new NotProductException();
            }
        }

        public virtual void ProductAdd()
        {
            Products product = new Products();

            product.productType = Seller.productsTypeFinding();
            product.ID = productList.Count + 1000; 
            transactionID = productList.Count + 1000;
            Console.WriteLine("Enter the price");  //Fiyatını giriniz
            product.amount = Convert.ToInt32(Console.ReadLine());
            product.color = Color.ColorFinfing();
            product.brand = Brands.BrandListFinding();
            product.Bodys = BodyChart.BodysFinding();
            product.patterns = Patterns.PatternsFinding();
            product.FabricType = Fabrics.PantsFabricTypeFinding();
            product.UserID = Seller.USERID;
            productList.Add(product);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("ID: " + ID);
            builder.Append(" brand: " + brand);
            builder.Append(" amount:" + amount);
            builder.Append(" color: " + color);
            builder.Append(" productType " + productType);
            return builder.ToString();
        }
    }
}
