using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };

            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyat = 15;
            product1.Açiklama = "Amasya Elması";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyat = 80;
            product2.Açiklama = "Diyrbakır Karpuzu";

            Product[] products=new Product[] {product1,product2}; //Array

            //type-safe--tip güvenli
            foreach (var product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyat);
                Console.WriteLine(product.Açiklama);
                Console.WriteLine("................");
                
            }

            Console.WriteLine("............Methot.........");

            //instance--Örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12,10);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12,10);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 10);

            Console.ReadLine();

        }
        
    }
}


//Dont report yourself - DRY-Clean Code-Bst Practice