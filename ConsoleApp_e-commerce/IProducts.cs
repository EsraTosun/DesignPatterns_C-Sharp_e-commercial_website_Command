using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    interface IProducts
    {
        void SellerProductsList();  //Satıcı Ürünleri Listele
        void ProductsList();        //Ürünleri Listele
        void FindingDesiredProduct();   //İstenilen Ürünü Bulmak
        void ProductDelete();   //Ürün sil
        void ProductAdd();  //Ürün ekle

    }
}
