using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    public class NotProductException : Exception
    {

        private static String description = "Ürün bulunamadı";

        public NotProductException() : base(description )
        {

        }

    }
}
