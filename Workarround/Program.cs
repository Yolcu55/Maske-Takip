using Entities.Concrete;

namespace Workarround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            SelamVer(isim: "Yunus");
            SelamVer(isim: "Ahmet");
            SelamVer(isim: "Ayşe");
            SelamVer();          
            

            int sonuç = Topla(6,58);

            //Dizi/ Arrays

            string öğrenci1 = "Engin";
            string öğrenci2 = "Kerem";
            string öğrenci3 = "Berkay";

            //Console.WriteLine(öğrenci1);
            //Console.WriteLine(öğrenci2);
            //Console.WriteLine(öğrenci3);

            string[] öğrenciler = new string[3];
            öğrenciler[0] = "Engin";
            öğrenciler[1] = "Kerem";
            öğrenciler[2] = "Berkay";
            
            öğrenciler = new string[4];
            öğrenciler[3] = "İlker";


            for (int i=0; i< öğrenciler.Length; i++)
            {
                Console.WriteLine(öğrenciler[i]);
            }
            string[] şehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] şehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };
            şehirler2 = şehirler1;
            şehirler1[0] = "Adana";
            Console.WriteLine(şehirler2[0]);

            Person person1=new Person();
            person1.FirstName = "Engin";
            person1.LastName = "Demiroğ";
            person1.DateOfBitrhYear = 1985;
            person1.NationaIdentity = 123;

            Person person2 = new Person();
            person2.FirstName = "Murat";

            foreach (string şehir in şehirler1)
            {
                Console.WriteLine(şehir);
            }

            //MyList
            List<string> yenişehirler1 = new List<string> { "Ankara1", "İatanbul1", "İzmir1" };
            yenişehirler1.Add("Adana1");
            foreach (var şehir in yenişehirler1)
            {
                Console.WriteLine(şehir);
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);


            Console.ReadLine();
        }
        //reshrper

        static void SelamVer(string isim="isimsiz")
        {
          
            Console.WriteLine("Merhaba"+ isim);

        }
        static int Topla(int sayi1=5, int sayi2=10)
        {
            int sonuç=sayi1 + sayi2;
            Console.WriteLine("Toplam:" + sonuç.ToString());
            return sonuç;

        }

    }
}