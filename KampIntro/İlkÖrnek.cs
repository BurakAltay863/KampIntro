using System;

namespace KampIntro
{
    class İlkÖrnek
    {
        static void Main(string[] args)
        {
            // type safety - tip güvenliği
            // Do not repeat yourself
            // değer tutucu alias

            string kategoriEtiketi = "Kategori";
            int ogreciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun=7.45;
            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("azalış butonu");

            }

            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi");
            }
            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı ayarlar butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);

            
        }
    }
}
