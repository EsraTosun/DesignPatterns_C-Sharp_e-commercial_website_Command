using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    interface ICustomer  //Müşteri
    {
        void AccountInformation();  //Hesap Bilgileri
        void MyBaskets();  //Sepetim
        void Favoritess();  //Favoriler
        void ProductsList();  //Ürünler
        void PaymentTransaction();
    }
}
