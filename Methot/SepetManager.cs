using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methot
{
    public class SepetManager
    {
        //naming Convention
        //syntax
        public void Ekle(Product product)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi: "+product.Adi);
            

        }
        public void Ekle2(string productAdi,string açiklama,double fiyat,int stokAdedi)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi: " + productAdi);

        }
    }
}
