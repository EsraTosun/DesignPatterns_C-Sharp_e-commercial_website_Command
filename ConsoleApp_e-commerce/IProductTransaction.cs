using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    interface IProductTransaction
    {
        void Execute();   //Çalıştırma

        void Undo();    //Geri Alma
    }
}
